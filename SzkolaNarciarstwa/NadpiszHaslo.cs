using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class NadpiszHaslo : Form
    {
        private ZarzadzajUzytkownikami zarzadzajUzytkownikami;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;"; // Ustaw dane połączenia

        public NadpiszHaslo()
        {
            InitializeComponent();
            this.zarzadzajUzytkownikami = zarzadzajUzytkownikami;
            // Wyświetl listę użytkowników w DataGridView
            WyswietlListeUzytkownikow();

            // Podłącz obsługę przycisków
            btnAnuluj.Click += BtnAnuluj_Click;
            btnNadpisz.Click += BtnNadpisz_Click;
        }

        private void WyswietlListeUzytkownikow()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT IDKursanci AS ID, Imie, Nazwisko, Email, Login, 'Kursant' AS Typ
                        FROM kursanci
                        UNION
                        SELECT IDPracownik AS ID, Imie, Nazwisko, Email, Login, Nazwa AS Typ
                        FROM pracownicy 
                        LEFT JOIN stanowiska ON pracownicy.IDStanowisko = stanowiska.IDStanowisko";

                    var adapter = new MySqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvUzytkownicy.DataSource = dataTable;
                    dgvUzytkownicy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvUzytkownicy.MultiSelect = false;

                    // Ukryj kolumnę ID
                    dgvUzytkownicy.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAnuluj_Click(object sender, EventArgs e)
        {
            // Powrót do panelu zarządzania użytkownikami
            var result = MessageBox.Show("Czy na pewno chcesz anulować zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void BtnNadpisz_Click(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać użytkownika z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pobierz ID użytkownika i typ (kursant/pracownik)
            var selectedRow = dgvUzytkownicy.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string userType = selectedRow.Cells["Typ"].Value.ToString();

            // Pokaż okno wprowadzania nowego hasła
            string newPassword = PromptForNewPassword();
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Hasło nie zostało wprowadzone lub anulowano operacje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Anulowanie
            }
            if (newPassword.Length < 8 || newPassword.Length > 64)
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 64 znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Zapisz nowe hasło dla tego użytkownika, zaraz zostanie zahashowane! Hasło : {newPassword} ", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Hashuj nowe hasło
            string hashedPassword = HashPassword(newPassword);

            // Zaktualizuj hasło w bazie danych
            bool result = UpdatePassword(userId, userType, hashedPassword);
            if (result)
            {
                MessageBox.Show("Hasło zostało pomyślnie zmienione.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private string PromptForNewPassword()
        {
            using (var passwordForm = new Form())
            {
                passwordForm.Text = "Wprowadź nowe hasło";
                passwordForm.Width = 400;
                passwordForm.Height = 150;

                var lblPassword = new Label { Text = "Nowe hasło:", Left = 20, Top = 20 };
                var txtPassword = new TextBox { Left = 120, Top = 20, Width = 200 };
                var btnConfirm = new Button { Text = "Zatwierdź", Left = 120, Top = 60, DialogResult = DialogResult.OK };
                var btnCancel = new Button { Text = "Anuluj", Left = 220, Top = 60, DialogResult = DialogResult.Cancel };

                passwordForm.Controls.Add(lblPassword);
                passwordForm.Controls.Add(txtPassword);
                passwordForm.Controls.Add(btnConfirm);
                passwordForm.Controls.Add(btnCancel);

                passwordForm.AcceptButton = btnConfirm;
                passwordForm.CancelButton = btnCancel;

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    return txtPassword.Text;
                }
                else
                {
                    return null;
                }
            }
        }

        private string HashPassword(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var hashBytes = SHA256.HashData(inputBytes);
            return Convert.ToHexString(hashBytes);
        }

        private bool UpdatePassword(int userId, string userType, string hashedPassword)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string tableName = userType == "Kursant" ? "kursanci" : "pracownicy";
                    string columnName = userType == "Kursant" ? "IDKursanci" : "IDPracownik";

                    string query = $"UPDATE {tableName} SET Haslo = @password WHERE {columnName} = @id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@id", userId);
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas aktualizacji hasła: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void panel112_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}