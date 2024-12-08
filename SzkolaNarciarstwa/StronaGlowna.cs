using System;
using System.Windows.Forms;

namespace SzkolaNarciarstwa
{
    public partial class StronaGlowna : Form
    {
        public StronaGlowna()
        {
            InitializeComponent();

            // Podłącz zdarzenia przycisków
            btnLoginKursant.Click += (sender, e) => OpenLoginForm(1); // 1 dla kursanta
            btnLoginPracownik.Click += (sender, e) => OpenLoginForm(2); // 2 dla pracownika
            btnRegister.Click += BtnRegister_Click;



        }


        private void OpenLoginForm(int typUzytkownika)
        {

            this.Hide(); // Ukryj StronaGlowna
            LoginForm loginForm = new LoginForm(this, typUzytkownika); // Przekaż StronaGlowna i typ użytkownika
            loginForm.FormClosed += (sender, e) => this.Show(); // Przy zamknięciu loginForm pokaż StronaGlowna
            loginForm.Show(); // Otwórz LoginForm
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ukryj StronaGlowna
            RegisterForm registerForm = new RegisterForm(this); // Utwórz nowy formularz rejestracji
            registerForm.FormClosed += (sender, e) => this.Show(); // Przy zamknięciu registerForm pokaż StronaGlowna
            registerForm.Show(); // Otwórz RegisterForm
        }

        private void StronaGlowna_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }
    }
}