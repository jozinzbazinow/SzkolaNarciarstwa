using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SzkolaNarciarstwa
{
    public partial class MojeKursy : Form
    {
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;";

        public MojeKursy()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        // Inicjalizacja ComboBoxa z typami kursów
        private void InitializeComboBox()
        {
            comboBoxCourseType.Items.Add("Przeszłe kursy");
            comboBoxCourseType.Items.Add("Aktualne kursy");
            comboBoxCourseType.Items.Add("Przyszłe kursy");
            comboBoxCourseType.SelectedIndex = 0; // Domyślnie "Przeszłe kursy"
            comboBoxCourseType.SelectedIndexChanged += ComboBoxCourseType_SelectedIndexChanged;

            // Załaduj domyślnie przeszłe kursy
            LoadCourses("past");
        }

        // Obsługa zmiany wyboru w ComboBoxie
        private void ComboBoxCourseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxCourseType.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Przeszłe kursy":
                    LoadCourses("past");
                    break;
                case "Aktualne kursy":
                    LoadCourses("current");
                    break;
                case "Przyszłe kursy":
                    LoadCourses("future");
                    break;
            }
        }

        // Ładowanie kursów w zależności od wybranego typu
        private void LoadCourses(string type)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string query;
                    connection.Open();
                    if (Program.GlobalVariables.stanowisko == 0)
                    {
                        query = GetQueryForType(type);
                    }
                    else if (Program.GlobalVariables.stanowisko == 1)
                    {
                        query = GetQueryForTypeInstruktor(type);
                    }
                    else
                    {
                        throw new InvalidOperationException($"Nieprawidłowy typ użytkownika.{Program.GlobalVariables.ID}");
                    }

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", Program.GlobalVariables.ID);
                        cmd.Parameters.AddWithValue("@today", DateTime.Now.Date);

                        using (var reader = cmd.ExecuteReader())
                        {
                            var coursesList = new List<string>();
                            while (reader.Read())
                            {
                                var startDate = Convert.ToDateTime(reader["DataRozpoczecia"]);
                                var endDate = Convert.ToDateTime(reader["DataZakonczenia"]);

                                // Formatowanie daty do short
                                string courseInfo = $"{reader["Nazwa"]} ({startDate.ToString("d")} - {endDate.ToString("d")})";
                                coursesList.Add(courseInfo);
                            }

                            listBoxCourses.Items.Clear();
                            if (coursesList.Count == 0)
                            {
                                listBoxCourses.Items.Add("Brak kursów w tej kategorii.");
                            }
                            else
                            {
                                listBoxCourses.Items.AddRange(coursesList.ToArray());
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

        // Zapytania SQL dla różnych typów kursów
        private string GetQueryForType(string type)
        {
            return type switch
            {
                "past" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyzapisy kz
                    INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kz.IDKlient = @userId AND kt.DataZakonczenia < @today",
                "current" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyzapisy kz
                    INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kz.IDKlient = @userId 
                    AND kt.DataRozpoczecia <= @today 
                    AND kt.DataZakonczenia >= @today",
                "future" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyzapisy kz
                    INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kz.IDKlient = @userId AND kt.DataRozpoczecia > @today",
                _ => throw new ArgumentException("Invalid course type")
            };
        }

        private string GetQueryForTypeInstruktor(string type)
        {
            return type switch
            {
                "past" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyzapisy kz
                    INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kz.IDPracownik = @userId AND kt.DataZakonczenia < @today",
                "current" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyzapisy kz
                    INNER JOIN kursyterminy kt ON kz.IDKursTermin = kt.IDKursTermin
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kz.IDPracownik = @userId 
                    AND kt.DataRozpoczecia <= @today 
                    AND kt.DataZakonczenia >= @today",
                "future" => @"
                    SELECT kr.Nazwa, kt.DataRozpoczecia, kt.DataZakonczenia
                    FROM kursyterminy kt
                    INNER JOIN kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
                    WHERE kt.IDPracownik = @userId AND kt.DataRozpoczecia > @today",
                _ => throw new ArgumentException("Invalid course type")
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}