using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class EdytujCene : Form
    {
        private EdytujOferte edytujOferte;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public EdytujCene(EdytujOferte edytujOferte)
        {
            InitializeComponent();
            this.edytujOferte = edytujOferte;
            WyswietlListeKursow();
        }

        private void WyswietlListeKursow()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Pobieranie danych z tabeli kursyrodzaje
                    string query = @"SELECT IDKursRodzaj AS ID, Nazwa, Opis, Cena, Zaawansowanie FROM kursyrodzaje";
                    var adapter = new MySqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Wyświetlanie danych w DataGridView
                    dgvKursy.DataSource = dataTable;
                    dgvKursy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz anulować zmianę ceny kursu?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                edytujOferte.Show();
            }
        }

        public void btnCenaEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvKursy.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę wybrać kurs z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvKursy.SelectedRows[0];
            int kursId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            // Pokaż okno wprowadzania nowej ceny
            int x = 0;
            string newPrice = PromptForNewPrice(x);
            if (string.IsNullOrEmpty(newPrice))
            {
                MessageBox.Show("Nie wprowadzono nowej ceny lub anulowano operacje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Anulowanie


            }

            if (!int.TryParse(newPrice, out int cena))
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę w polu cena.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cena < 10 || cena > 5000)
            {
                MessageBox.Show("Zła cena. Cena powinna wynosić od 10 do 5000 zł", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Update ceny w bazie danych
                    string query = @"UPDATE kursyrodzaje SET Cena = @Cena WHERE IDKursRodzaj = @ID";
                    using (var insertCmd = new MySqlCommand(query, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Cena", cena);
                        insertCmd.Parameters.AddWithValue("@ID", kursId);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cena kursu została pomyślnie zmieniona.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    edytujOferte.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string PromptForNewPrice(int x)
        {
            using (var priceForm = new Form())
            {
                priceForm.Text = "Wprowadź nową cenę kursu";
                priceForm.Width = 400;
                priceForm.Height = 150;

                var lblCena = new Label { Text = "Nowa cena:", Left = 20, Top = 20 };
                var txtCena = new TextBox { Left = 120, Top = 20, Width = 200 };
                var btnConfirm = new Button { Text = "Zatwierdź", Left = 120, Top = 60, DialogResult = DialogResult.OK };
                var btnCancel = new Button { Text = "Anuluj", Left = 220, Top = 60, DialogResult = DialogResult.Cancel };

                priceForm.Controls.Add(lblCena);
                priceForm.Controls.Add(txtCena);
                priceForm.Controls.Add(btnConfirm);
                priceForm.Controls.Add(btnCancel);

                priceForm.AcceptButton = btnConfirm;
                priceForm.CancelButton = btnCancel;

                var result = priceForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    priceForm.Close();
                    this.Close();
                    edytujOferte.Show();

                }

                if (result == DialogResult.OK)
                {
                    return txtCena.Text;
                }

                return null;
            }
        }
    }
}