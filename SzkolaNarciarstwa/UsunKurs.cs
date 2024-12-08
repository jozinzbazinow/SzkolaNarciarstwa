using System;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SzkolaNarciarstwa
{
    public partial class UsunKurs : Form
    {

        private EdytujOferte edytujOferte;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public UsunKurs(EdytujOferte edytujOferte)
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
            this.Hide();
            edytujOferte.Show();
        }


        private void btnUsun_Click_1(object sender, EventArgs e)
        {
            if (dgvKursy.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć kurs do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dgvKursy.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value);


                        string deleteQuery = "DELETE FROM kursyrodzaje WHERE IDKursRodzaj = @ID";

                        using (var command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ID", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Zaznaczone kurs został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    edytujOferte.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas usuwania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
