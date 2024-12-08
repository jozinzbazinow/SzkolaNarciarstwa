using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class EdytujOferte : Form
    {

        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public EdytujOferte(PanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            this.panelUzytkownika = panelUzytkownika;
            WyswietlEdytujOferte();
        }

        private void WyswietlEdytujOferte()
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelUzytkownika.Show(); // Powrót do głównego formularza
        }

        private void btnDodajKurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKurs dodajKurs = new DodajKurs(this);
            dodajKurs.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsunKurs usunKurs = new UsunKurs(this);
            usunKurs.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujCene edytujCene = new EdytujCene(this);
            edytujCene.Show();
        }
    }
}
