using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class EdytujDaneSzkoly : Form
    {

        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public EdytujDaneSzkoly(PanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            this.panelUzytkownika = panelUzytkownika;
            WyswietlEdytujDaneSzkoly();
        }
        private void WyswietlEdytujDaneSzkoly()
        {
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT Nazwa, Miejscowosc, KodPocztowy, Ulica, TelefonKontaktowy, Email FROM szkoly WHERE IDSzkola = 1";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNazwa.Text = reader["Nazwa"].ToString();
                                txtMiejscowosc.Text = reader["Miejscowosc"].ToString();
                                txtKodPocztowy.Text = reader["KodPocztowy"].ToString();
                                txtUlica.Text = reader["Ulica"].ToString();
                                txtTelefonKontaktowy.Text = reader["TelefonKontaktowy"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas ładowania danych: {ex.Message}");
                    }
                }
            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            var wynik = MessageBox.Show("Czy na pewno chcesz anulować zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (wynik == DialogResult.Yes)
            {
                this.Close();
                panelUzytkownika.Show();
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE szkoly 
                                     SET Nazwa = @Nazwa, Miejscowosc = @Miejscowosc, 
                                         KodPocztowy = @KodPocztowy, Ulica = @Ulica, 
                                         TelefonKontaktowy = @TelefonKontaktowy, Email = @Email
                                     WHERE IDSzkola = 1";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nazwa", txtNazwa.Text);
                    command.Parameters.AddWithValue("@Miejscowosc", txtMiejscowosc.Text);
                    command.Parameters.AddWithValue("@KodPocztowy", txtKodPocztowy.Text);
                    command.Parameters.AddWithValue("@Ulica", txtUlica.Text);
                    command.Parameters.AddWithValue("@TelefonKontaktowy", txtTelefonKontaktowy.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dane zostały zapisane pomyślnie.");
                        this.Close();
                        panelUzytkownika.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się zapisać danych.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisywania danych: {ex.Message}");
                }
            }
        }
    }
}
