using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;

namespace SzkolaNarciarstwa
{
    public partial class UtworzKontoSluzbowe : Form
    {
        private ZarzadzajUzytkownikami zarzadzajUzytkownikami;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;"; // Ustaw dane połączenia

        public UtworzKontoSluzbowe(ZarzadzajUzytkownikami zarzadzajUzytkownikami)
        {
            InitializeComponent();
            this.zarzadzajUzytkownikami = zarzadzajUzytkownikami;
        }




        private string GenerateRandomPassword()
        {
            // Generowanie losowego hasła (8 znaków, mieszanka liter i cyfr)
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            char[] password = new char[8];
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        private void btnPowrot_Click_1(object sender, EventArgs e)
        {
            var wynik = MessageBox.Show("Czy na pewno chcesz anulować zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (wynik == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnUtworzKonto_Click(object sender, EventArgs e)
        {
            {
                // Pobranie danych z formularza
                string imie = txtImie.Text.Trim();
                string nazwisko = txtNazwisko.Text.Trim();
                string email = txtEmail.Text.Trim();
                string login = txtLogin.Text.Trim();
                string stanowisko = cmbStanowisko.SelectedItem?.ToString();

                // Walidacja danych
                if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(login) || string.IsNullOrEmpty(stanowisko))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Nieprawidłowy adres e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (imie.Length < 2 || imie.Length > 30)
                {
                    MessageBox.Show("Nieprawidłowe imie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nazwisko.Length < 2 || nazwisko.Length > 30)
                {
                    MessageBox.Show("Nieprawidłowe nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idStanowisko;
                switch (stanowisko)
                {
                    case "Instruktor":
                        idStanowisko = 1;
                        break;
                    case "Manager":
                        idStanowisko = 2;
                        break;
                    case "Administrator":
                        idStanowisko = 3;
                        break;
                    default:
                        MessageBox.Show("Nieprawidłowe stanowisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                string haslo = GenerateRandomPassword();


                using (var connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Sprawdzenie unikalności loginu i e-maila
                        string checkQuery = "SELECT COUNT(*) FROM pracownicy WHERE Login = @Login OR Email = @Email";
                        using (var checkCmd = new MySqlCommand(checkQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@Login", login);
                            checkCmd.Parameters.AddWithValue("@Email", email);

                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Login lub e-mail już istnieje w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        MessageBox.Show($"Zapisz hasło użytkownika. Hasło zostanie podane enkrypcji. Hasło to: {haslo}", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        string QuickHash(string input)
                        {
                            var inputBytes = Encoding.UTF8.GetBytes(input);
                            var inputHash = SHA256.HashData(inputBytes);
                            return Convert.ToHexString(inputHash);
                        }

                        haslo = QuickHash(haslo);
                        // Wstawienie nowego użytkownika
                        string insertQuery = @"INSERT INTO pracownicy (Imie, Nazwisko, Email, Login, Haslo, IDStanowisko) 
                                           VALUES (@Imie, @Nazwisko, @Email, @Login, @Haslo, @IDStanowisko)";
                        using (var insertCmd = new MySqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@Imie", imie);
                            insertCmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@Login", login);
                            insertCmd.Parameters.AddWithValue("@Haslo", haslo);
                            insertCmd.Parameters.AddWithValue("@IDStanowisko", idStanowisko);

                            insertCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Konto zostało pomyślnie utworzone.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        zarzadzajUzytkownikami.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}