using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SzkolaNarciarstwa
{
    public partial class CzasPracy : Form
    {
        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;password=;";
        private const decimal HourlyRate = 45m; // Hourly rate for instructors
        private const decimal ManagerSalary = 8000m; // Fixed monthly salary for managers
        private const int ManagerHours = 160; // Fixed full-time hours for managers

        public CzasPracy(PanelUzytkownika panelUzytkownika)
        {
            this.panelUzytkownika = panelUzytkownika;
            InitializeComponent();
            LoadWyswietlCzasPracy();
        }

        private void LoadWyswietlCzasPracy()
        {
            try
            {
                int stanowisko = Program.GlobalVariables.stanowisko;
                int userId = Program.GlobalVariables.ID;

                if (stanowisko == 1)
                {
                    DisplayInstructorCourses(userId);
                }
                else if (stanowisko == 2)
                {
                    DisplayManagerHours();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInstructorCourses(int instructorId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
    SELECT 
        kr.Nazwa AS NazwaKursu, 
        kt.IloscGodzin, 
        kt.DataRozpoczecia,
        kt.DataZakonczenia,
        kt.IloscGodzin * @hourlyRate AS KursWynagrodzenie
    FROM 
        kursyterminy kt
    JOIN 
        kursyrodzaje kr ON kt.IDKursRodzaj = kr.IDKursRodzaj
    WHERE 
        kt.IDPracownik = @instructorId AND kt.IloscGodzin > 0
        AND MONTH(kt.DataZakonczenia) = MONTH(CURRENT_DATE())
        AND YEAR(kt.DataZakonczenia) = YEAR(CURRENT_DATE());";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@instructorId", instructorId);
                    command.Parameters.AddWithValue("@hourlyRate", HourlyRate);

                    using (var reader = command.ExecuteReader())
                    {
                        decimal totalHours = 0;
                        decimal totalSalary = 0;

                        listBoxCourses.Items.Clear();

                        while (reader.Read())
                        {
                            var startDate = Convert.ToDateTime(reader["DataRozpoczecia"]);
                            var endDate = Convert.ToDateTime(reader["DataZakonczenia"]);
                            string courseName = reader["NazwaKursu"].ToString();
                            decimal courseHours = reader.GetDecimal("IloscGodzin");
                            decimal courseSalary = reader.GetDecimal("KursWynagrodzenie");
                            string courseDate = $"{startDate.ToString("d")} - {endDate.ToString("d")}";

                            totalHours += courseHours;
                            totalSalary += courseSalary;

                            listBoxCourses.Items.Add($"{courseName}:          {courseHours} godz.            {courseDate}            {courseSalary:C}");
                        }

                        lblTotalHours.Text = $"Łącznie godzin: {totalHours}";
                        lblTotalSalary.Text = $"Łącznie wypłata: {totalSalary:C}";
                    }
                }
            }
        }

        private void DisplayManagerHours()
        {
            lblTotalHours.Text = $"Łącznie godzin: {ManagerHours}";
            lblTotalSalary.Text = $"Łącznie wypłata: {ManagerSalary:C}";
            listBoxCourses.Visible = false;
            listBoxCourses.Items.Clear();
            listBoxCourses.Items.Add("Manager nie prowadzi kursów.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}