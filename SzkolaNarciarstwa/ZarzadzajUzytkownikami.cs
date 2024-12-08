using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzkolaNarciarstwa
{
    public partial class ZarzadzajUzytkownikami : Form
    {
        private PanelUzytkownika panelUzytkownika;
        private string connectionString = "server=localhost;database=szkola;uid=root;"; // Ustaw swoje dane połączenia

        public ZarzadzajUzytkownikami(PanelUzytkownika panelUzytkownika)
        {
            InitializeComponent();
            this.panelUzytkownika = panelUzytkownika;
            WyswietlZarzadzajUzytkownikami();
        }

        private void WyswietlZarzadzajUzytkownikami()
        {

        }

        private void btnUtworzKonto_Click(object sender, EventArgs e)
        {
            panelUzytkownika.ShowChildForm(typeof(UtworzKontoSluzbowe), this);
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUsunKonto_Click(object sender, EventArgs e)
        {
            panelUzytkownika.ShowChildForm(typeof(UsunKontoAdmin), this); // Wyświetlenie formularza w panelu
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            panelUzytkownika.ShowChildForm(typeof(NadpiszHaslo));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
