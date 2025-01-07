using System.Text;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace SzkolaNarciarstwa
{
    public partial class PotwierdzenieUsunieciaKonta : Form
    {
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;";
        private Form panelUzytkownika;
        private Form loginForm;
        private Form stronaGlowna;

        public PotwierdzenieUsunieciaKonta(Form loginForm)
        {
            InitializeComponent();
            
            this.loginForm = loginForm;
            btnPotwierdz.Click += BtnPotwierdz_Click;
        }
        private void UsunKonto(MySqlConnection connection)
        {

            try
            {

                string deleteQuery = "DELETE FROM kursanci WHERE IDKursanci = @ID";
                using (var command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", Program.GlobalVariables.ID);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Konto zostało pomyślnie usunięte.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Zamknięcie aplikacji lub przekierowanie do panelu logowania
                LoginForm loginForm = new LoginForm(null, 1); // Tworzenie instancji LoginForm
                this.Close();
                loginForm.Show(); // Wyświetlenie panelu logowania
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas usuwania konta: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPotwierdz_Click(object sender, EventArgs e)
        {
            {
                string wprowadzoneHaslo = txtHaslo.Text.Trim();
                string QuickHash(string input)
                {
                    var inputBytes = Encoding.UTF8.GetBytes(input);
                    var inputHash = SHA256.HashData(inputBytes);
                    return Convert.ToHexString(inputHash);
                }

                wprowadzoneHaslo = QuickHash(wprowadzoneHaslo);

                // Weryfikacja hasła
                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM kursanci WHERE IDKursanci = @ID AND Haslo = @Haslo";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", Program.GlobalVariables.ID);
                            command.Parameters.AddWithValue("@Haslo", wprowadzoneHaslo);

                            int wynik = Convert.ToInt32(command.ExecuteScalar());

                            if (wynik == 1) // Hasło poprawne
                            {

                                UsunKonto(connection);
                            }
                            else
                            {
                                MessageBox.Show("Podane hasło jest niepoprawne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}