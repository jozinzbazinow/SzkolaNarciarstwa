namespace SzkolaNarciarstwa
{
    partial class NadpiszHaslo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUzytkownicy = new DataGridView();
            btnNadpisz = new Button();
            btnAnuluj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).BeginInit();
            SuspendLayout();
            // 
            // dgvUzytkownicy
            // 
            dgvUzytkownicy.Anchor = AnchorStyles.None;
            dgvUzytkownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUzytkownicy.Location = new Point(73, -45);
            dgvUzytkownicy.Margin = new Padding(3, 2, 3, 2);
            dgvUzytkownicy.Name = "dgvUzytkownicy";
            dgvUzytkownicy.RowHeadersWidth = 51;
            dgvUzytkownicy.Size = new Size(564, 349);
            dgvUzytkownicy.TabIndex = 0;
            // 
            // btnNadpisz
            // 
            btnNadpisz.Anchor = AnchorStyles.None;
            btnNadpisz.Location = new Point(387, 320);
            btnNadpisz.Margin = new Padding(3, 2, 3, 2);
            btnNadpisz.Name = "btnNadpisz";
            btnNadpisz.Size = new Size(200, 58);
            btnNadpisz.TabIndex = 2;
            btnNadpisz.Text = "Nadpisz hasło";
            btnNadpisz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Anchor = AnchorStyles.None;
            btnAnuluj.Location = new Point(127, 320);
            btnAnuluj.Margin = new Padding(3, 2, 3, 2);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(200, 58);
            btnAnuluj.TabIndex = 1;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // NadpiszHaslo
            // 
            AcceptButton = btnNadpisz;
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(728, 357);
            Controls.Add(dgvUzytkownicy);
            Controls.Add(btnNadpisz);
            Controls.Add(btnAnuluj);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NadpiszHaslo";
            Text = "NadpiszHaslo";
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUzytkownicy;
        private Button btnNadpisz;
        private Button btnAnuluj;
    }
}