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
            panel1 = new Panel();
            btnAnuluj = new Button();
            btnNadpisz = new Button();
            panel5 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUzytkownicy
            // 
            dgvUzytkownicy.Anchor = AnchorStyles.None;
            dgvUzytkownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUzytkownicy.Location = new Point(262, 104);
            dgvUzytkownicy.Margin = new Padding(3, 2, 3, 2);
            dgvUzytkownicy.Name = "dgvUzytkownicy";
            dgvUzytkownicy.RowHeadersWidth = 51;
            dgvUzytkownicy.Size = new Size(508, 341);
            dgvUzytkownicy.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnAnuluj);
            panel1.Controls.Add(btnNadpisz);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 468);
            panel1.TabIndex = 21;
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.Maroon;
            btnAnuluj.Dock = DockStyle.Top;
            btnAnuluj.FlatStyle = FlatStyle.Popup;
            btnAnuluj.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnAnuluj.ForeColor = Color.Transparent;
            btnAnuluj.Location = new Point(5, 63);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(231, 58);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            // 
            // btnNadpisz
            // 
            btnNadpisz.BackColor = Color.SeaGreen;
            btnNadpisz.Dock = DockStyle.Top;
            btnNadpisz.FlatStyle = FlatStyle.Popup;
            btnNadpisz.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnNadpisz.ForeColor = Color.Transparent;
            btnNadpisz.Location = new Point(5, 5);
            btnNadpisz.Name = "btnNadpisz";
            btnNadpisz.Size = new Size(231, 58);
            btnNadpisz.TabIndex = 7;
            btnNadpisz.Text = "Zapisz";
            btnNadpisz.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 87);
            panel5.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 29);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 0;
            label2.Text = "NADPISZ HASŁO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NadpiszHaslo
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(782, 468);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(dgvUzytkownicy);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NadpiszHaslo";
            Text = "NadpiszHaslo";
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUzytkownicy;
        private Button btnNadpisz;
        private Button btnAnuluj;
        private Panel panel1;
        private Panel panel5;
        private Label label2;
    }
}