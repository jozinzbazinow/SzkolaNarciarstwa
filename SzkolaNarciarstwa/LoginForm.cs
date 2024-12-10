using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace SzkolaNarciarstwa
{
    public partial class LoginForm : Form
    {
        private Form mainForm;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Zmień na odpowiednie dane
        private int typUzytkownika;
        private Form stronaGlowna;

        public LoginForm(Form mainForm, int typUzytkownika)
        {
            InitializeComponent();
            this.typUzytkownika = typUzytkownika;
            this.mainForm = mainForm;

            if (mainForm is StronaGlowna)
            {
                this.stronaGlowna = mainForm; // Przypisz referencję do StronaGlowna
            }

            // Podłącz zdarzenia przycisków
            btnSubmit.Click += BtnSubmit_Click;
            btnBack.Click += BtnBack_Click;
        }

        public TextBox TxtUsernameL => txtUsername;    /* Dla testów zmienne */
        public TextBox TxtPasswordL => txtPassword;
        public Button BtnSubmit => btnSubmit;
        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string QuickHash(string input)
            {
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var inputHash = SHA256.HashData(inputBytes);
                return Convert.ToHexString(inputHash);
            }

            password = QuickHash(password);
            int wynikLogowania = ValidateLogin(username, password);
            if (wynikLogowania >= 0)
            {
                this.Hide();
                PanelUzytkownika panelUzytkownika = new PanelUzytkownika(mainForm); // Przekazanie powrotu do StronaGlowna
                panelUzytkownika.FormClosed += (s, args) => this.Show(); // Wracaj do LoginForm po zamknięciu panelu
                panelUzytkownika.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private int ValidateLogin(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Wybór zapytania na podstawie typu użytkownika
                    string query = typUzytkownika switch
                    {
                        2 => "SELECT IDPracownik, IDStanowisko FROM pracownicy WHERE Login = @username AND Haslo = @password",
                        1 => "SELECT IDkursanci FROM kursanci WHERE Login = @username AND Haslo = @password",
                        //_ => null // Obsługa błędów #niepotrzebne, błąd będzie i tak

                    };

                    if (query == null)
                    {
                        MessageBox.Show("Nieprawidłowy typ użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1; // Błąd w przypadku niepoprawnego typu użytkownika
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        if (typUzytkownika == 1) // Logowanie kursanta
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int kursantId))
                            {
                                Program.GlobalVariables.stanowisko = 0; // Kursant
                                Program.GlobalVariables.ID = kursantId; // ID kursanta
                                return 0; // Zwróć 0 dla kursanta
                            }
                            else
                            {
                                return -1; // Kursant nie znaleziony
                            }
                        }

                        if (typUzytkownika == 2) // Logowanie pracownika
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int pracownikId = reader.GetInt32("IDPracownik");
                                    int stanowisko = reader.GetInt32("IDStanowisko");

                                    Program.GlobalVariables.stanowisko = stanowisko; // Stanowisko pracownika
                                    Program.GlobalVariables.ID = pracownikId; // ID pracownika
                                    return stanowisko; // Zwróć stanowisko (1, 2, 3, ...)
                                }
                                else
                                {
                                    return -1; // Pracownik nie znaleziony
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd MySQL: {ex.Message}\n{ex.StackTrace}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Domyślnie zwróć -1 w przypadku błędów
        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (stronaGlowna != null)
            {
                stronaGlowna.Show(); // Pokaż StronaGlowna, jeśli jest dostępne
            }
            else
            {
                var stronaGlowna = new StronaGlowna();
                stronaGlowna.Show();
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
