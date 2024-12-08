using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class RegisterForm : Form
    {
        private Form mainForm;
        private string connectionString = "server=localhost;database=szkola;uid=root;";

        public RegisterForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Podłącz zdarzenia przycisków
            btnSubmit.Click += BtnSubmit_Click;
            btnBack.Click += BtnBack_Click;
        }
        public TextBox TxtUsername => txtUsername;
        public TextBox TxtPassword1 => txtPassword1;
        public TextBox TxtPassword2 => txtPassword2;
        public TextBox TxtEmail => txtEmail;
        public Button BtnSubmit => btnSubmit;
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            string email = txtEmail.Text;
            //  zapis do bazy danych
            ValidateRegister( username,  password1, password2,  email);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Powrót do głównego okna
            this.Hide();
            mainForm.Show();
        }
        private bool ValidateRegister(string username, string password1, string password2, string email)
        {
            // Walidacja danych
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password1) ||
                string.IsNullOrWhiteSpace(password2) ||
                string.IsNullOrWhiteSpace(email) )
            {
                MessageBox.Show("Wprowadź wszystkie dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Czyszczenie pól
                txtUsername.Clear();
                txtPassword1.Clear();
                txtPassword2.Clear();
                txtEmail.Clear();
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Hasła nie są identyczne!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Czyszczenie pól
                txtUsername.Clear();
                txtPassword1.Clear();
                txtPassword2.Clear();
                txtEmail.Clear();
            }
            else if (password1.Length < 8 || password1.Length > 64)
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 64 znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Czyszczenie pól
                txtUsername.Clear();
                txtPassword1.Clear();
                txtPassword2.Clear();
                txtEmail.Clear();
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Czyszczenie pól
                txtUsername.Clear();
                txtPassword1.Clear();
                txtPassword2.Clear();
                txtEmail.Clear();
            }
            
            else
            {
                string QuickHash(string input)
                {
                    var inputBytes = Encoding.UTF8.GetBytes(input);
                    var inputHash = SHA256.HashData(inputBytes);
                    return Convert.ToHexString(inputHash);
                }

                password1 = QuickHash(password1);
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        // Sprawdzenie unikalności numeru telefonu i e-maila
                        string checkQuery = "SELECT COUNT(*) FROM kursanci WHERE Login = @username";
                        using (var checkCmd = new MySqlCommand(checkQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@username", username );
                            

                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Istnieje już użytkownik o takim loginie!.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        string query = "INSERT INTO `kursanci` (`Email`, `Login`, `Haslo`) VALUES (@email, @username, @password);\n";
                        if (query == null)
                        {
                            MessageBox.Show("Coś poszło nie tak.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password1);
                            command.Parameters.AddWithValue("@email", email);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Rejestracja zakończona sukcesem.\nLogin: {username}\nHasło (hash): {password1}", "Debug", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd MySQL: {ex.Message}\n{ex.StackTrace}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Przekierowanie do logowania
                this.Hide();
                LoginForm loginForm = new LoginForm(mainForm, 1);
                loginForm.Show();
                return true;    
            }
            return true;
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
    }
}
