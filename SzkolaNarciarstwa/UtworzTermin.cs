using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzkolaNarciarstwa
{
    public partial class UtworzTermin : Form
    {
        private IPanelUzytkownika _panelUzytkownika;
        private PanelUzytkownika PanelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;"; // Ustaw dane połączenia
        public UtworzTermin(IPanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            _panelUzytkownika = panelUzytkownika;
        }
        private void UtworzTermin_Load(object sender, EventArgs e)
        {
            LoadInstruktorzy();
            LoadKursy();
        }
        public class ComboBoxItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Określa, co będzie wyświetlane w ComboBox
            }
        }
        private void LoadInstruktorzy()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IDPracownik, CONCAT(Imie, ' ', Nazwisko) AS Instruktor FROM pracownicy WHERE IDStanowisko = 1";
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();
                    bool hasRows = false;
                    while (reader.Read())
                    {
                        hasRows = true;
                        cmbInstruktor.Items.Add(new ComboBoxItem
                        {
                            ID = reader.GetInt32("IDPracownik"),
                            Name = reader.GetString("Instruktor")
                        });
                    }

                    if (!hasRows)
                    {
                        MessageBox.Show("Brak instruktorów do załadowania.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania instruktorów: " + ex.Message);
                }
            }
        }

        private void LoadKursy()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IDKursRodzaj, Nazwa FROM kursyrodzaje";
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbNazwaKursu.Items.Add(new ComboBoxItem
                        {
                            ID = reader.GetInt32("IDKursRodzaj"),
                            Name = reader.GetString("Nazwa")
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania kursów: " + ex.Message);
                }
            }
        }
        public int UtworzTerminExec(DateTime dataRozpoczecia, DateTime dataZakonczenia, string iloscGodzin1, string iloscMiejsc1, int idInstruktor, int idKursRodzaj)
        {

            if (idInstruktor == null || idKursRodzaj == null || iloscGodzin1 == null || iloscMiejsc1 == null)
            {
                MessageBox.Show("Uzupełnij wszystkie pola w formularzu!");
                return -1;
            }

            if (!int.TryParse(iloscGodzin1, out int iloscGodzin))
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę w polu Ilośc Godzin!.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (iloscGodzin < 1 || iloscGodzin > 100)
            {
                MessageBox.Show("Niepoprawna liczba godzin. Powinna ona wynosić od 1 do 100!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (!int.TryParse(iloscMiejsc1, out int iloscMiejsc))
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę w polu Ilośc Godzin!.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (iloscMiejsc != 15)
            {
                MessageBox.Show("Liczba uczestników kursu powinna wynosić 15 kursantów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if (dataRozpoczecia < DateTime.Now.Date)
            {
                MessageBox.Show("Data rozpoczęcia kursu nie może być w przeszłości!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }


            if ((dataZakonczenia - dataRozpoczecia).TotalDays > 365)
            {
                MessageBox.Show("Kurs nie może trwać dłużej niż 1 rok!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                MessageBox.Show("Termin został dodany!");
                return 0;
            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            var wynik = MessageBox.Show("Czy na pewno chcesz anulować zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (wynik == DialogResult.Yes)
            {
                this.Close();
                PanelUzytkownika.Show();
            }
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            var dataRozpoczecia = dateTerminKursu.Value.Date;
            var dataZakonczenia = dateKoniecKursu.Value.Date;
            var iloscGodzin1 = txtIloscGodzin.Text;
            var iloscMiejsc1 = txtIloscMiejsc.Text;
            var idInstruktor = (cmbInstruktor.SelectedItem as dynamic)?.ID;
            var idKursRodzaj = (cmbNazwaKursu.SelectedItem as dynamic)?.ID;
            UtworzTerminExec(dataRozpoczecia, dataZakonczenia, iloscGodzin1, iloscMiejsc1, idInstruktor, idKursRodzaj);
        }

        private void dateTerminKursu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTerminKursu_Click(object sender, EventArgs e)
        {

        }

        private void cmbInstruktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblInstruktor_Click(object sender, EventArgs e)
        {

        }

        private void cmbNazwaKursu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNazwaKursu_Click(object sender, EventArgs e)
        {

        }

        private void txtIloscGodzin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
