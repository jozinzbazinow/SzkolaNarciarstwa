namespace SzkolaNarciarstwa
{
    partial class UtworzTermin
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
            btmDodajTermin = new Button();
            btnPowrot = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            lblKoniec = new Label();
            lblIloscGodzin = new Label();
            panel5 = new Panel();
            label1 = new Label();
            txtIloscGodzin = new TextBox();
            lblNazwaKursu = new Label();
            lblIloscMiejsc = new Label();
            dateTerminKursu = new DateTimePicker();
            txtIloscMiejsc = new TextBox();
            lblTerminKursu = new Label();
            dateKoniecKursu = new DateTimePicker();
            lblInstruktor = new Label();
            cmbNazwaKursu = new ComboBox();
            cmbInstruktor = new ComboBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btmDodajTermin
            // 
            btmDodajTermin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btmDodajTermin.BackColor = Color.FromArgb(48, 46, 100);
            btmDodajTermin.BackgroundImageLayout = ImageLayout.None;
            btmDodajTermin.Cursor = Cursors.Hand;
            btmDodajTermin.Dock = DockStyle.Top;
            btmDodajTermin.FlatAppearance.BorderSize = 0;
            btmDodajTermin.FlatStyle = FlatStyle.Flat;
            btmDodajTermin.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btmDodajTermin.ForeColor = Color.Transparent;
            btmDodajTermin.Location = new Point(0, 0);
            btmDodajTermin.Name = "btmDodajTermin";
            btmDodajTermin.Size = new Size(211, 58);
            btmDodajTermin.TabIndex = 1;
            btmDodajTermin.Text = "Dodaj Termin";
            btmDodajTermin.UseVisualStyleBackColor = false;
            btmDodajTermin.Click += btnDodajTermin_Click;
            // 
            // btnPowrot
            // 
            btnPowrot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPowrot.BackColor = Color.FromArgb(48, 46, 100);
            btnPowrot.BackgroundImageLayout = ImageLayout.None;
            btnPowrot.Cursor = Cursors.Hand;
            btnPowrot.Dock = DockStyle.Top;
            btnPowrot.FlatAppearance.BorderSize = 0;
            btnPowrot.FlatStyle = FlatStyle.Flat;
            btnPowrot.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnPowrot.ForeColor = Color.Transparent;
            btnPowrot.Location = new Point(0, 58);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(211, 58);
            btnPowrot.TabIndex = 2;
            btnPowrot.Text = "Powrót";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 54, 74);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 468);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(lblKoniec);
            panel4.Controls.Add(lblIloscGodzin);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtIloscGodzin);
            panel4.Controls.Add(lblNazwaKursu);
            panel4.Controls.Add(lblIloscMiejsc);
            panel4.Controls.Add(dateTerminKursu);
            panel4.Controls.Add(txtIloscMiejsc);
            panel4.Controls.Add(lblTerminKursu);
            panel4.Controls.Add(dateKoniecKursu);
            panel4.Controls.Add(lblInstruktor);
            panel4.Controls.Add(cmbNazwaKursu);
            panel4.Controls.Add(cmbInstruktor);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panel4.Location = new Point(211, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 468);
            panel4.TabIndex = 16;
            // 
            // lblKoniec
            // 
            lblKoniec.Anchor = AnchorStyles.None;
            lblKoniec.AutoSize = true;
            lblKoniec.Location = new Point(35, 412);
            lblKoniec.Name = "lblKoniec";
            lblKoniec.Size = new Size(150, 16);
            lblKoniec.TabIndex = 13;
            lblKoniec.Text = "Termin zakonczenia kursu";
            lblKoniec.Click += label1_Click;
            // 
            // lblIloscGodzin
            // 
            lblIloscGodzin.Anchor = AnchorStyles.None;
            lblIloscGodzin.AutoSize = true;
            lblIloscGodzin.Location = new Point(57, 241);
            lblIloscGodzin.Name = "lblIloscGodzin";
            lblIloscGodzin.Size = new Size(73, 16);
            lblIloscGodzin.TabIndex = 12;
            lblIloscGodzin.Text = "Ilość Godzin";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 14;
            panel5.Paint += panel5_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 33);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "UTWÓRZ TERMIN";
            label1.Click += label1_Click_1;
            // 
            // txtIloscGodzin
            // 
            txtIloscGodzin.Anchor = AnchorStyles.None;
            txtIloscGodzin.Location = new Point(191, 241);
            txtIloscGodzin.Name = "txtIloscGodzin";
            txtIloscGodzin.Size = new Size(100, 22);
            txtIloscGodzin.TabIndex = 11;
            txtIloscGodzin.TextChanged += txtIloscGodzin_TextChanged;
            // 
            // lblNazwaKursu
            // 
            lblNazwaKursu.Anchor = AnchorStyles.None;
            lblNazwaKursu.AutoSize = true;
            lblNazwaKursu.Location = new Point(43, 129);
            lblNazwaKursu.Name = "lblNazwaKursu";
            lblNazwaKursu.Size = new Size(77, 16);
            lblNazwaKursu.TabIndex = 5;
            lblNazwaKursu.Text = "Nazwa kursu";
            lblNazwaKursu.Click += lblNazwaKursu_Click;
            // 
            // lblIloscMiejsc
            // 
            lblIloscMiejsc.Anchor = AnchorStyles.None;
            lblIloscMiejsc.AutoSize = true;
            lblIloscMiejsc.Location = new Point(57, 296);
            lblIloscMiejsc.Name = "lblIloscMiejsc";
            lblIloscMiejsc.Size = new Size(69, 16);
            lblIloscMiejsc.TabIndex = 10;
            lblIloscMiejsc.Text = "Ilość Miejsc";
            // 
            // dateTerminKursu
            // 
            dateTerminKursu.Anchor = AnchorStyles.None;
            dateTerminKursu.Format = DateTimePickerFormat.Short;
            dateTerminKursu.Location = new Point(189, 354);
            dateTerminKursu.Name = "dateTerminKursu";
            dateTerminKursu.Size = new Size(102, 22);
            dateTerminKursu.TabIndex = 0;
            dateTerminKursu.ValueChanged += dateTerminKursu_ValueChanged;
            // 
            // txtIloscMiejsc
            // 
            txtIloscMiejsc.Anchor = AnchorStyles.None;
            txtIloscMiejsc.Location = new Point(191, 293);
            txtIloscMiejsc.Name = "txtIloscMiejsc";
            txtIloscMiejsc.Size = new Size(100, 22);
            txtIloscMiejsc.TabIndex = 9;
            txtIloscMiejsc.Text = "15";
            // 
            // lblTerminKursu
            // 
            lblTerminKursu.Anchor = AnchorStyles.None;
            lblTerminKursu.AutoSize = true;
            lblTerminKursu.Location = new Point(35, 359);
            lblTerminKursu.Name = "lblTerminKursu";
            lblTerminKursu.Size = new Size(148, 16);
            lblTerminKursu.TabIndex = 3;
            lblTerminKursu.Text = "Termin rozpoczęcia kursu";
            lblTerminKursu.Click += lblTerminKursu_Click;
            // 
            // dateKoniecKursu
            // 
            dateKoniecKursu.Anchor = AnchorStyles.None;
            dateKoniecKursu.Format = DateTimePickerFormat.Short;
            dateKoniecKursu.Location = new Point(189, 407);
            dateKoniecKursu.Name = "dateKoniecKursu";
            dateKoniecKursu.Size = new Size(102, 22);
            dateKoniecKursu.TabIndex = 8;
            // 
            // lblInstruktor
            // 
            lblInstruktor.Anchor = AnchorStyles.None;
            lblInstruktor.AutoSize = true;
            lblInstruktor.Location = new Point(41, 175);
            lblInstruktor.Name = "lblInstruktor";
            lblInstruktor.Size = new Size(64, 16);
            lblInstruktor.TabIndex = 4;
            lblInstruktor.Text = "Instruktor";
            lblInstruktor.Click += lblInstruktor_Click;
            // 
            // cmbNazwaKursu
            // 
            cmbNazwaKursu.Anchor = AnchorStyles.None;
            cmbNazwaKursu.BackColor = Color.White;
            cmbNazwaKursu.FormattingEnabled = true;
            cmbNazwaKursu.Location = new Point(131, 126);
            cmbNazwaKursu.Name = "cmbNazwaKursu";
            cmbNazwaKursu.Size = new Size(200, 24);
            cmbNazwaKursu.TabIndex = 7;
            cmbNazwaKursu.SelectedIndexChanged += cmbNazwaKursu_SelectedIndexChanged;
            // 
            // cmbInstruktor
            // 
            cmbInstruktor.Anchor = AnchorStyles.None;
            cmbInstruktor.FormattingEnabled = true;
            cmbInstruktor.Location = new Point(129, 175);
            cmbInstruktor.Name = "cmbInstruktor";
            cmbInstruktor.Size = new Size(200, 24);
            cmbInstruktor.TabIndex = 6;
            cmbInstruktor.SelectedIndexChanged += cmbInstruktor_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 46, 84);
            panel3.Controls.Add(btnPowrot);
            panel3.Controls.Add(btmDodajTermin);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 468);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 14;
            // 
            // UtworzTermin
            // 
            AcceptButton = btmDodajTermin;
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(782, 468);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UtworzTermin";
            Text = "UtworzTermin";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btmDodajTermin;
        private Button btnPowrot;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Label lblKoniec;
        private Label lblIloscGodzin;
        private TextBox txtIloscGodzin;
        private Label lblNazwaKursu;
        private Label lblIloscMiejsc;
        private DateTimePicker dateTerminKursu;
        private TextBox txtIloscMiejsc;
        private Label lblTerminKursu;
        private DateTimePicker dateKoniecKursu;
        private Label lblInstruktor;
        private ComboBox cmbNazwaKursu;
        private ComboBox cmbInstruktor;
    }
}