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
            btnPowrot = new Button();
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
            BtnUtworzKonto = new Button();
            SuspendLayout();
            // 
            // btnPowrot
            // 
            btnPowrot.Location = new Point(438, 366);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(114, 29);
            btnPowrot.TabIndex = 0;
            btnPowrot.Text = "Anuluj";
            btnPowrot.UseVisualStyleBackColor = true;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(346, 43);
            txtImie.Multiline = true;
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(155, 50);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(346, 108);
            txtNazwisko.Multiline = true;
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(155, 50);
            txtNazwisko.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(346, 175);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 50);
            txtEmail.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(346, 240);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(155, 50);
            txtLogin.TabIndex = 4;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Items.AddRange(new object[] { "Instruktor", "Manager", "Administrator" });
            cmbStanowisko.Location = new Point(346, 313);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(155, 28);
            cmbStanowisko.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 56);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 6;
            label1.Text = "Imie :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 192);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "Adres e-mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 259);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Login :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 316);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 10;
            label5.Text = "Stanowisko :";
            // 
            // BtnUtworzKonto
            // 
            BtnUtworzKonto.Location = new Point(287, 366);
            BtnUtworzKonto.Name = "BtnUtworzKonto";
            BtnUtworzKonto.Size = new Size(124, 29);
            BtnUtworzKonto.TabIndex = 11;
            BtnUtworzKonto.Text = "Utwórz konto";
            BtnUtworzKonto.UseVisualStyleBackColor = true;
            BtnUtworzKonto.Click += BtnUtworzKonto_Click_1;
            // 
            // UtworzKontoSluzbowe
            // 
            AcceptButton = BtnUtworzKonto;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnUtworzKonto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStanowisko);
            Controls.Add(txtLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnPowrot);
            Name = "UtworzKontoSluzbowe";
            Text = "UtworzKontoSluzbowe";
            ResumeLayout(false);
            PerformLayout();
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
    }
}