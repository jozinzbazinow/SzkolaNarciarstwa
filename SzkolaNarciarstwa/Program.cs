using System;
using System.Windows.Forms;

namespace SzkolaNarciarstwa
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tworzenie instancji formularza g³ównego
            StronaGlowna stronaGlowna = new StronaGlowna();

            // Przypisanie formularza g³ównego jako mainForm
            GlobalVariables.mainForm = stronaGlowna;

            // Tworzenie formularza logowania i przekazanie odniesienia do StronaGlowna
            LoginForm loginForm = new LoginForm(stronaGlowna, 0);
            Application.Run(stronaGlowna);
        }

        public static class GlobalVariables
        {
            public static int stanowisko;
            public static int ID;
            public static Form mainForm;
        }
    }
}