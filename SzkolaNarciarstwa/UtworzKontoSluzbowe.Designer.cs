namespace SzkolaNarciarstwa
{
    partial class UtworzKontoSluzbowe
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
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtEmail = new TextBox();
            txtLogin = new TextBox();
            cmbStanowisko = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            BtnUtworzKonto = new Button();
            btnPowrot = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Anchor = AnchorStyles.None;
            txtImie.Location = new Point(172, 94);
            txtImie.Margin = new Padding(3, 2, 3, 2);
            txtImie.Multiline = true;
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(210, 24);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Anchor = AnchorStyles.None;
            txtNazwisko.Location = new Point(172, 147);
            txtNazwisko.Margin = new Padding(3, 2, 3, 2);
            txtNazwisko.Multiline = true;
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(210, 24);
            txtNazwisko.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(172, 203);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 24);
            txtEmail.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.Location = new Point(172, 251);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(210, 24);
            txtLogin.TabIndex = 4;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.Anchor = AnchorStyles.None;
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Items.AddRange(new object[] { "Instruktor", "Manager", "Administrator" });
            cmbStanowisko.Location = new Point(172, 302);
            cmbStanowisko.Margin = new Padding(3, 2, 3, 2);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(210, 24);
            cmbStanowisko.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(46, 97);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 6;
            label1.Text = "Imie :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(46, 150);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(46, 206);
            label3.Name = "label3";
            label3.Size = new Size(81, 16);
            label3.TabIndex = 8;
            label3.Text = "Adres e-mail :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(46, 259);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 9;
            label4.Text = "Login :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(46, 305);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 10;
            label5.Text = "Stanowisko :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(BtnUtworzKonto);
            panel1.Controls.Add(btnPowrot);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 429);
            panel1.TabIndex = 21;
            // 
            // BtnUtworzKonto
            // 
            BtnUtworzKonto.BackColor = Color.SeaGreen;
            BtnUtworzKonto.Dock = DockStyle.Top;
            BtnUtworzKonto.FlatStyle = FlatStyle.Popup;
            BtnUtworzKonto.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            BtnUtworzKonto.ForeColor = Color.Transparent;
            BtnUtworzKonto.Location = new Point(5, 63);
            BtnUtworzKonto.Name = "BtnUtworzKonto";
            BtnUtworzKonto.Size = new Size(231, 58);
            BtnUtworzKonto.TabIndex = 9;
            BtnUtworzKonto.Text = "Utwórz konto";
            BtnUtworzKonto.UseVisualStyleBackColor = false;
            BtnUtworzKonto.Click += BtnUtworzKonto_Click;
            // 
            // btnPowrot
            // 
            btnPowrot.BackColor = Color.Maroon;
            btnPowrot.Dock = DockStyle.Top;
            btnPowrot.FlatStyle = FlatStyle.Popup;
            btnPowrot.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnPowrot.ForeColor = Color.Transparent;
            btnPowrot.Location = new Point(5, 5);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(231, 58);
            btnPowrot.TabIndex = 0;
            btnPowrot.Text = "Anuluj";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += btnPowrot_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbStanowisko);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNazwisko);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtImie);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(241, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 429);
            panel2.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(525, 87);
            panel5.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(172, 38);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 0;
            label6.Text = "UTWÓRZ KONTO";
            label6.Click += label6_Click;
            // 
            // UtworzKontoSluzbowe
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 429);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UtworzKontoSluzbowe";
            Text = "UtworzKontoSluzbowe";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPowrot;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private ComboBox cmbStanowisko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnUtworzKonto;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Label label6;
    }
}