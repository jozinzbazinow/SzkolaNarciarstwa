using System;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SzkolaNarciarstwa
{
    public partial class DodajKurs : Form
    {

        private EdytujOferte edytujOferte;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public DodajKurs(EdytujOferte edytujOferte)
        {
            InitializeComponent();
            this.edytujOferte = edytujOferte;
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Czy na pewno chcesz anulować dodawanie oferty?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                edytujOferte.Show();
            }
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            string nazwa = txtNazwa.Text.Trim();
            string opis = txtOpis.Text.Trim();
            string cen = txtCena.Text.Trim();
            string poziom = cmbPoziom.SelectedItem?.ToString();

            // Walidacja danych
            if (string.IsNullOrEmpty(nazwa) || string.IsNullOrEmpty(opis) || string.IsNullOrEmpty(cen) ||string.IsNullOrEmpty(cen) ||
                string.IsNullOrEmpty(poziom))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nazwa.Length < 1 || nazwa.Length > 40)
            {
                MessageBox.Show("Nazwa kursu powinna zawierać od 1 do 40 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (opis.Length < 1 || opis.Length > 200)
            {
                MessageBox.Show("Opis kursu powinien zawierać od 1 do 200 znaków.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cen, out int cena))
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

                    // Sprawdzenie unikalności kursu
                    string checkQuery = "SELECT COUNT(*) FROM kursyrodzaje WHERE Nazwa = @Nazwa";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Nazwa", nazwa);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Kurs o takiej nazwie już istnieje w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                  
                    // Wstawienie kursu do oferty
                    string insertQuery = @"INSERT INTO kursyrodzaje (Nazwa, Opis, Cena, Zaawansowanie) 
                                           VALUES (@Nazwa, @Opis, @Cena, @Zaawansowanie)";
                    using (var insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        insertCmd.Parameters.AddWithValue("@Opis", opis);
                        insertCmd.Parameters.AddWithValue("@Cena", cena);
                        insertCmd.Parameters.AddWithValue("@Zaawansowanie", poziom);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kurs został pomyślnie dodany do oferty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    edytujOferte.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}