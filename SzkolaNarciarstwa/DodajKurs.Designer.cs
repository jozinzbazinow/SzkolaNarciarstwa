namespace SzkolaNarciarstwa
{
    partial class DodajKurs
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
            btnAnuluj = new Button();
            txtNazwa = new TextBox();
            txtOpis = new TextBox();
            txtCena = new TextBox();
            cmbPoziom = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnZatwierdz = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.Maroon;
            btnAnuluj.Dock = DockStyle.Top;
            btnAnuluj.FlatStyle = FlatStyle.Popup;
            btnAnuluj.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnAnuluj.ForeColor = Color.Transparent;
            btnAnuluj.Location = new Point(5, 5);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(231, 58);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtNazwa
            // 
            txtNazwa.Anchor = AnchorStyles.None;
            txtNazwa.Location = new Point(448, 112);
            txtNazwa.Multiline = true;
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(203, 47);
            txtNazwa.TabIndex = 1;
            // 
            // txtOpis
            // 
            txtOpis.Anchor = AnchorStyles.None;
            txtOpis.Location = new Point(448, 178);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(203, 47);
            txtOpis.TabIndex = 2;
            // 
            // txtCena
            // 
            txtCena.Anchor = AnchorStyles.None;
            txtCena.Location = new Point(448, 243);
            txtCena.Multiline = true;
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(203, 47);
            txtCena.TabIndex = 3;
            // 
            // cmbPoziom
            // 
            cmbPoziom.Anchor = AnchorStyles.None;
            cmbPoziom.FormattingEnabled = true;
            cmbPoziom.Items.AddRange(new object[] { "Początkujący", "Średnio-zaawansowany", "Zaawansowany", "Ekspert" });
            cmbPoziom.Location = new Point(448, 318);
            cmbPoziom.Name = "cmbPoziom";
            cmbPoziom.Size = new Size(203, 27);
            cmbPoziom.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(336, 128);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 5;
            label1.Text = "Nazwa kursu :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(336, 192);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 6;
            label2.Text = "Opis kursu :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(336, 257);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 7;
            label3.Text = "Cena :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(336, 320);
            label4.Name = "label4";
            label4.Size = new Size(110, 19);
            label4.TabIndex = 8;
            label4.Text = "Poziom zaaw. :";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.BackColor = Color.SeaGreen;
            btnZatwierdz.Dock = DockStyle.Top;
            btnZatwierdz.FlatStyle = FlatStyle.Popup;
            btnZatwierdz.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnZatwierdz.ForeColor = Color.Transparent;
            btnZatwierdz.Location = new Point(5, 63);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(231, 58);
            btnZatwierdz.TabIndex = 9;
            btnZatwierdz.Text = "Zatwierdź wprowadzony kurs";
            btnZatwierdz.UseVisualStyleBackColor = false;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnZatwierdz);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 468);
            panel1.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 87);
            panel5.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(176, 29);
            label6.Name = "label6";
            label6.Size = new Size(202, 25);
            label6.TabIndex = 0;
            label6.Text = "DODAJ NOWY KURS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DodajKurs
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPoziom);
            Controls.Add(txtCena);
            Controls.Add(txtOpis);
            Controls.Add(txtNazwa);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DodajKurs";
            Text = "DodajKurs";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnuluj;
        private TextBox txtNazwa;
        private TextBox txtOpis;
        private TextBox txtCena;
        private ComboBox cmbPoziom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnZatwierdz;
        private Panel panel1;
        private Panel panel5;
        private Label label6;
    }
}