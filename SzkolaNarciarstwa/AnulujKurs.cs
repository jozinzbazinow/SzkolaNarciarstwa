using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SzkolaNarciarstwa.AnulujKurs;

namespace SzkolaNarciarstwa
{
    public partial class AnulujKurs : Form
    {
        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;";


        public AnulujKurs(PanelUzytkownika panelUzytkownika)
        {
            this.panelUzytkownika = panelUzytkownika;
            InitializeComponent();
            LoadKursyDoAnulowania();
        }

        private class ListBoxItem
        {
            public int Id { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void LoadKursyDoAnulowania()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT kz.IDKursZapis AS IDKursu, kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                FROM kursyzapisy kz
                INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                WHERE kz.IDKlient = @userId
                AND kt.DataRozpoczecia > @today";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", Program.GlobalVariables.ID);
                        cmd.Parameters.AddWithValue("@today", DateTime.Now.Date);

                        using (var reader = cmd.ExecuteReader())
                        {
                            listBoxKursy.Items.Clear();
                            while (reader.Read())
                            {
                                var startDate = Convert.ToDateTime(reader["DataRozpoczecia"]);
                                var endDate = Convert.ToDateTime(reader["DataZakonczenia"]);
                                int idKursu = Convert.ToInt32(reader["IDKursu"]);
                                string kursInfo = $"{reader["Nazwa"]} ({startDate.ToString("d")} - {endDate.ToString("d")})";
                                listBoxKursy.Items.Add(new ListBoxItem
                                {
                                    Id = idKursu,
                                    Text = kursInfo
                                });

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania kursów: {ex.Message}");

            }

        }

        private void btnAnulujKurs_Click(object sender, EventArgs e)
        {
            {
                if (listBoxKursy.SelectedItem == null)
                {
                    MessageBox.Show("Proszę wybrać kurs do anulowania.");
                    return;
                }

                // Pobranie ID wybranego kursu
                int idKursu = ((ListBoxItem)listBoxKursy.SelectedItem).Id;

                // Wyświetlenie warunków anulowania
                DialogResult result = MessageBox.Show(
                    "Za anulowanie kursu należy uiścić opłatę w wysokości 50 zł w kasie szkoły. Czy akceptujesz ten warunek?",
                    "Warunki anulowania kursu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Anulowanie kursu zostało przerwane.");
                    return;
                }

                try
                {
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Usunięcie zapisu z bazy danych
                        string deleteQuery = "DELETE FROM kursyzapisy WHERE IDKursZapis = @kursId";
                        using (var cmd = new MySqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@kursId", idKursu);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kurs został pomyślnie anulowany.");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas anulowania kursu: {ex.Message}");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}