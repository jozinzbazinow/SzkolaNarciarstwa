using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace SzkolaNarciarstwa
{
    public interface IPanelUzytkownika
    {
        void Show();
    }
    public partial class PanelUzytkownika : Form, IPanelUzytkownika
    {
        private Form mainForm;
        public PanelUzytkownika(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void PanelUzytkownika_Load(object sender, EventArgs e)
        {
            // Pobierz nazwę użytkownika
            int userId = Program.GlobalVariables.ID; // Identyfikator użytkownika
            string username = GetUsernameFromDatabase();

            // Ustaw nazwę użytkownika jako tekst Label
            lblUsername.Text = $"Witaj, {username}!";

            // Inne operacje w metodzie Load
            btnEdit.Visible = false;
            BtnZarzadzajUzytkownikami.Visible = false;
            btnUsunKonto.Visible = false;
            btnEdytujDaneSzkoly.Visible = false;
            btnEdytujOferte.Visible = false;
            btnUtworzTerminarz.Visible = false;
            btnZapis.Visible = false;
            btnKursPrzeglad.Visible = false;
            btnZapis.Visible = false;
            btnAnulujZapis.Visible = false;
            btnWorkTIme.Visible = false;
            if (Program.GlobalVariables.stanowisko == 3)
            {
                BtnZarzadzajUzytkownikami.Visible = true;
                btnEdytujDaneSzkoly.Visible = true;
                btnEdytujOferte.Visible = true;
            }

            if (Program.GlobalVariables.stanowisko == 0)
            {
                btnEdit.Visible = true;
                btnUsunKonto.Visible = true;
                btnZapis.Visible = true;
                btnAnulujZapis.Visible = true;
                btnKursPrzeglad.Visible = true;
            }

            if (Program.GlobalVariables.stanowisko == 1)
            {
                btnEdit.Visible = true;
                btnKursPrzeglad.Visible = true;
                btnWorkTIme.Visible = true;
            }

            if (Program.GlobalVariables.stanowisko == 2)
            {
                btnEdit.Visible = true;
                btnEdytujDaneSzkoly.Visible = true;
                btnEdytujOferte.Visible = true;
                btnUtworzTerminarz.Visible = true;
                btnWorkTIme.Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(EdycjaDanychProfilowych), this);
        }

        private void BtnZarzadzajUzytkownikami_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(ZarzadzajUzytkownikami), this);
        }

        private void btnUsunKonto_Click(object sender, EventArgs e)
        {
            //this.panelUzytkownika = panelUzytkownika;
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wykonać tę akcję?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PotwierdzenieUsunieciaKonta potwierdzenieForm = new PotwierdzenieUsunieciaKonta(Program.GlobalVariables.mainForm);
                ShowChildForm(typeof(PotwierdzenieUsunieciaKonta), this);

            }
        }

        private void btnEdytujDaneSzkoly_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(EdytujDaneSzkoly), this);

        }

        private void btnEdytujOferte_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(EdytujOferte), this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUtworzTerminarz_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(UtworzTermin), this);
        }
        private void btnZapisNaKurs_Click(object sender, EventArgs e)
        {

        }

        private void btnKursPrzeglad_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(MojeKursy), this);
        }
        public void ShowChildForm(Type formType, params object[] parameters)
        {
            // Ukrywamy lub usuwamy poprzedni formularz z panelu
            foreach (Control control in this.pnlParent.Controls)
            {
                if (control is Form)
                {
                    control.Hide(); // Ukrywamy poprzedni formularz
                    control.Dispose(); // Usuwamy go z pamięci
                }
            }

            // Sprawdzamy, czy typ formularza ma konstruktor, który przyjmuje parametry
            var constructors = formType.GetConstructors();

            foreach (var constructor in constructors)
            {
                var parameterInfos = constructor.GetParameters();

                // Jeśli konstruktor nie ma parametrów, tworzymy formularz bez parametrów
                if (parameterInfos.Length == 0)
                {
                    Form childForm = (Form)Activator.CreateInstance(formType);
                    InitializeChildForm(childForm);
                    return;
                }

                // Jeśli konstruktor ma parametry, sprawdzamy, czy możemy je dopasować
                if (parameterInfos.Length == parameters.Length)
                {
                    bool canCreate = true;
                    for (int i = 0; i < parameterInfos.Length; i++)
                    {
                        if (!parameterInfos[i].ParameterType.IsAssignableFrom(parameters[i].GetType()))
                        {
                            canCreate = false;
                            break;
                        }
                    }

                    // Jeśli parametry pasują, tworzymy formularz z przekazanymi parametrami
                    if (canCreate)
                    {
                        Form childForm = (Form)Activator.CreateInstance(formType, parameters);
                        InitializeChildForm(childForm);
                        return;
                    }
                }
            }

            // Jeśli żaden konstruktor nie pasuje, zgłaszamy wyjątek
            throw new ArgumentException("Nie znaleziono odpowiedniego konstruktora dla tego formularza.");
        }

        private void InitializeChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Dodajemy formularz do panelu
            this.pnlParent.Controls.Add(childForm);
            childForm.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
        private string GetUsernameFromDatabase()
        {
            string username = string.Empty;
            string connectionString = "server=localhost;database=szkola;uid=root;"; // Twój connection string
            int userId = Program.GlobalVariables.ID;
            int stanowisko = Program.GlobalVariables.stanowisko;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = stanowisko switch
                    {
                        0 => "SELECT Imie FROM kursanci WHERE IDkursanci = @userId", // Kursanci
                        _ => "SELECT Imie FROM pracownicy WHERE IDPracownik = @userId" // Pracownicy
                    };

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            username = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd MySQL: {ex.Message}\n{ex.StackTrace}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return username;
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(ZapisNaKurs), this);
        }

        private void btnAnulujZapis_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(AnulujKurs), this);
        }

        private void btnWorkTIme_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(CzasPracy), this);
        }
    }
}
