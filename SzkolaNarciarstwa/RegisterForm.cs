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
        public TextBox TxtUsername => txtUsername;    /* Dla testów zmienne */
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
        public int ValidateRegister(string username, string password1, string password2, string email)     //zmienic na private po testach
        {
            // Walidacja danych
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password1) ||
                string.IsNullOrWhiteSpace(password2) ||
                string.IsNullOrWhiteSpace(email) )
            {
                MessageBox.Show("Wprowadź wszystkie dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Hasła nie są identyczne!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (password1.Length < 8 || password1.Length > 64)
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 64 znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
            else
            {
                return 0;
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
    }
}
