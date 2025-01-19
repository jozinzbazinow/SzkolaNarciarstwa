using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Data;

namespace SzkolaNarciarstwa
{
    public partial class UsunKontoAdmin : Form
    {
        private ZarzadzajUzytkownikami zarzadzajUzytkownikami;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;"; // Ustaw dane połączenia

        public UsunKontoAdmin(ZarzadzajUzytkownikami zarzadzajUzytkownikami)
        {
            InitializeComponent();
            this.zarzadzajUzytkownikami = zarzadzajUzytkownikami;
            WyswietlListeUzytkownikow();
        }
        private void WyswietlListeUzytkownikow()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Pobieranie danych z tabel instruktorzy i kursanci
                    string query = @"
                        SELECT IDKursanci AS ID, Imie, Nazwisko, Email, Login, 'Kursant' AS Typ
                        FROM kursanci
                        UNION
                        SELECT IDPracownik AS ID, Imie, Nazwisko, Email, Login, Nazwa AS Typ
                        FROM pracownicy 
                        LEFT JOIN stanowiska ON pracownicy.IDStanowisko = stanowiska.IDStanowisko WHERE pracownicy.IDStanowisko NOT IN ('2', '3') ";

                    var adapter = new MySqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Wyświetlanie danych w DataGridView
                    dgvUzytkownicy.DataSource = dataTable;
                    dgvUzytkownicy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvUzytkownicy.MultiSelect = true;

                    // Ukrywanie kolumny ID w tabeli
                    dgvUzytkownicy.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            zarzadzajUzytkownikami.Show();
        }

        private void btnUsun_Click_1(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć co najmniej jedno konto do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone konta?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dgvUzytkownicy.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            string typ = row.Cells["Typ"].Value.ToString();

                            string deleteQuery = typ == "Kursant"
                                ? "DELETE FROM kursanci WHERE IDKursanci = @ID"
                                : "DELETE FROM pracownicy WHERE IDPracownik = @ID";

                            using (var command = new MySqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", id);
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Zaznaczone konta zostały pomyślnie usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WyswietlListeUzytkownikow(); // Odświeżenie listy po usunięciu
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
