using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class EdytujOferte : Form
    {
        private Form mainForm;
        private Form panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia z BD

        public EdytujOferte(PanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            this.panelUzytkownika = panelUzytkownika;
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
            ((PanelUzytkownika)panelUzytkownika).ShowChildForm(typeof(DodajKurs), this);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            ((PanelUzytkownika)panelUzytkownika).ShowChildForm(typeof(UsunKurs), this);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ((PanelUzytkownika)panelUzytkownika).ShowChildForm(typeof(EdytujCene), this);
        }
    }
}
