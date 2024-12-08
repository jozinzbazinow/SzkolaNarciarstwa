using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SzkolaNarciarstwa.ZapisNaKurs;

namespace SzkolaNarciarstwa
{
    public partial class ZapisNaKurs : Form
    {
        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;"; // Ustaw dane połączenia
        private int pracownikId; // ID pracownika przypisanego do kursu

        public ZapisNaKurs(PanelUzytkownika panelUzytkownika)
        {
            this.panelUzytkownika = panelUzytkownika;
            InitializeComponent();
            LoadDostepneKursy();
        }

        public class Kurs
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        public class Termin
        {
            public int ID { get; set; }
            public int pracownikId { get; set; }
            public string Description { get; set; }
            public int IloscMiejsc { get; set; }
            public override string ToString()
            {
                return Description;
            }
        }

        private void LoadDostepneKursy()
        {
            cmbKursy.Items.Clear();
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IDKursRodzaj, Nazwa FROM kursyrodzaje WHERE aktualne = 1";
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbKursy.Items.Add(new Kurs
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

        private void cmbKursy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedKurs = cmbKursy.SelectedItem as Kurs;
            if (selectedKurs != null)
            {

                LoadTerminy(selectedKurs.ID, pracownikId);
            }
        }

        private void LoadTerminy(int kursId, int pracownikId)
        {
            cmbTerminy.Items.Clear();
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT IDKursTermin, 
                       CONCAT(DataRozpoczecia, ' - ', DataZakonczenia) AS Termin, 
                       IloscMiejsc, IDPracownik
                FROM kursyterminy 
                WHERE IDKursRodzaj = @KursId AND DataRozpoczecia > CURDATE()"; // Dodano warunek dla daty
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KursId", kursId);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbTerminy.Items.Add(new Termin
                        {
                            pracownikId = reader.GetInt32("IDPracownik"),
                            ID = reader.GetInt32("IDKursTermin"),
                            Description = reader.GetString("Termin"),
                            IloscMiejsc = reader.GetInt32("IloscMiejsc")
                        });
                    }

                    if (cmbTerminy.Items.Count == 0)
                    {
                        MessageBox.Show("Brak dostępnych terminów dla wybranego kursu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas ładowania terminów: " + ex.Message);
                }
            }
        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnuluj_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click_1(object sender, EventArgs e)
        {
            var selectedTermin = cmbTerminy.SelectedItem as Termin;
            if (selectedTermin == null)
            {
                MessageBox.Show("Wybierz termin kursu przed zapisaniem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTermin.IloscMiejsc <= 0)
            {
                MessageBox.Show("Brak miejsc na wybrany termin kursu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    // Sprawdzenie, czy użytkownik jest już zapisany na ten kurs
                    string checkQuery = "SELECT COUNT(*) FROM kursyzapisy WHERE IDKursTermin = @IDKursTermin AND IDKlient = @IDKlient";
                    var checkCommand = new MySqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@IDKursTermin", selectedTermin.ID);
                    checkCommand.Parameters.AddWithValue("@IDKlient", Program.GlobalVariables.ID);

                    int zapisCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (zapisCount > 0)
                    {
                        MessageBox.Show("Jesteś już zapisany na ten kurs.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Aktualizacja liczby miejsc
                    string updateQuery = "UPDATE kursyterminy SET IloscMiejsc = IloscMiejsc - 1 WHERE IDKursTermin = @IDKursTermin";
                    var updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@IDKursTermin", selectedTermin.ID);
                    updateCommand.ExecuteNonQuery();

                    // Zapisanie użytkownika na kurs
                    string zapisQuery = @"INSERT INTO kursyzapisy (IDKursTermin, IDPracownik, IDKlient) VALUES (@IDKursTermin, @IDPracownik, @IDKlient)";
                    var zapisCommand = new MySqlCommand(zapisQuery, connection);
                    zapisCommand.Parameters.AddWithValue("@IDKursTermin", selectedTermin.ID);
                    zapisCommand.Parameters.AddWithValue("@IDPracownik", selectedTermin.pracownikId); // Użyj IDPracownik z terminu
                    zapisCommand.Parameters.AddWithValue("@IDKlient", Program.GlobalVariables.ID);
                    zapisCommand.ExecuteNonQuery();

                    MessageBox.Show("Zapisano na kurs!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas zapisywania na kurs: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}