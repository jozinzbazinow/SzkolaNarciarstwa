using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SzkolaNarciarstwa
{
    public partial class EdycjaDanychProfilowych : Form
    {
        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public EdycjaDanychProfilowych(PanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            this.panelUzytkownika = panelUzytkownika;
            WyswietlDaneProfilowe();
        }

        private void WyswietlDaneProfilowe()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = Program.GlobalVariables.stanowisko == 0
                        ? "SELECT Imie, Nazwisko, Email, NumerTelefonu, DataUrodzenia FROM kursanci WHERE IDKursanci = @id"
                        : "SELECT Imie, Nazwisko, Email, NumerTelefonu, DataUrodzenia FROM pracownicy WHERE IDPracownik = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Program.GlobalVariables.ID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtImie.Text = reader["Imie"] as string ?? "";
                                txtNazwisko.Text = reader["Nazwisko"] as string ?? "";
                                txtEmail.Text = reader["Email"] as string ?? "";
                                txtNumer.Text = reader["NumerTelefonu"]?.ToString() ?? "";
                                if (reader["DataUrodzenia"] != DBNull.Value)
                                {
                                    // Jeśli nie jest NULL, przypisujemy datę do DateTimePicker
                                    dateTimePicker1.Value = Convert.ToDateTime(reader["DataUrodzenia"]);
                                }
                                else
                                {
                                    // Jeśli DataUrodzenia jest NULL, ustawiamy DateTimePicker na "pustą" datę
                                    dateTimePicker1.Value = new DateTime(2000, 1, 1); ;  // Ustawienie domyślnej daty
                                    dateTimePicker1.CustomFormat = " ";  // Ustawienie pustego formatu
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono danych użytkownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private bool WalidujDane(string imie, string nazwisko, string email, string telefon, DateTime? dataUrodzenia)
        {
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!long.TryParse(telefon, out _))
            {
                MessageBox.Show("Numer telefonu musi być liczbą. Sprawdź czy nie występują zbędne spacje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (telefon.Length != 9)
            {
                MessageBox.Show("Podaj prawidłowy numer telefonu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (imie.Length < 2 || imie.Length > 30)
            {
                MessageBox.Show("Nieprawidłowe imie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nazwisko.Length < 2 || nazwisko.Length > 30)
            {
                MessageBox.Show("Nieprawidłowe nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Walidacja daty urodzenia (sprawdzanie, czy data nie jest pusta)
            if (dataUrodzenia.HasValue)
            {
                // Upewniamy się, że data urodzenia jest w sensownym przedziale (np. nie w przyszłości)
                if (dataUrodzenia.Value > DateTime.Now)
                {
                    MessageBox.Show("Data urodzenia nie może być w przyszłości.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Data urodzenia nie może być pusta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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


        private void BtnAnuluj_Click_1(object sender, EventArgs e)
        {
            var wynik = MessageBox.Show("Czy na pewno chcesz anulować zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (wynik == DialogResult.Yes)
            {
                this.Close();
                panelUzytkownika.Show();
            }
        }

        private void BtnZapisz_Click(object sender, EventArgs e)
        {
            string noweImie = txtImie.Text.Trim();
            string noweNazwisko = txtNazwisko.Text.Trim();
            string nowyEmail = txtEmail.Text.Trim();
            string nowyNumer = txtNumer.Text.Trim();
            DateTime? dataUrodzenia = dateTimePicker1.Value != dateTimePicker1.MinDate ? (DateTime?)dateTimePicker1.Value : null; // Sprawdzamy, czy data urodzenia jest ustawiona

            // Przekazujemy datę urodzenia do walidacji
            if (!WalidujDane(noweImie, noweNazwisko, nowyEmail, nowyNumer, dataUrodzenia))
            {
                lblKomunikat.Text = "Popraw błędy i spróbuj ponownie.";
                lblKomunikat.ForeColor = Color.Red;
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    if (Program.GlobalVariables.stanowisko != 0)
                    {
                        // Sprawdzenie unikalności numeru telefonu i e-maila
                        MessageBox.Show(Program.GlobalVariables.ID.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string checkQuery = "SELECT COUNT(*) FROM pracownicy WHERE (NumerTelefonu = @telefon OR Email = @email) AND NOT IDPracownik = @id";
                        using (var checkCmd = new MySqlCommand(checkQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@telefon", nowyNumer);
                            checkCmd.Parameters.AddWithValue("@email", nowyEmail);
                            checkCmd.Parameters.AddWithValue("@id", Program.GlobalVariables.ID);

                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (count != 0)
                            {
                                MessageBox.Show("Numer telefonu lub e-mail dla pracownika już istnieje w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    
                    string query = Program.GlobalVariables.stanowisko == 0
                        ? @"UPDATE kursanci 
                    SET Imie = @imie, Nazwisko = @nazwisko, Email = @email, NumerTelefonu = @telefon, DataUrodzenia = @dataUrodzenia 
                    WHERE IDKursanci = @id"
                        : @"UPDATE pracownicy 
                    SET Imie = @imie, Nazwisko = @nazwisko, Email = @email, NumerTelefonu = @telefon, DataUrodzenia = @dataUrodzenia 
                    WHERE IDPracownik = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", noweImie);
                        command.Parameters.AddWithValue("@nazwisko", noweNazwisko);
                        command.Parameters.AddWithValue("@email", nowyEmail);
                        command.Parameters.AddWithValue("@telefon", nowyNumer);
                        command.Parameters.AddWithValue("@dataUrodzenia", dataUrodzenia.HasValue ? (object)dataUrodzenia.Value : DBNull.Value); // Dodajemy datę urodzenia lub NULL
                        command.Parameters.AddWithValue("@id", Program.GlobalVariables.ID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dane zostały zaktualizowane pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            panelUzytkownika.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nie udało się zaktualizować danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
