namespace SzkolaNarciarstwa
{
    partial class EdytujDaneSzkoly
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
            txtNazwa = new TextBox();
            txtMiejscowosc = new TextBox();
            txtKodPocztowy = new TextBox();
            txtUlica = new TextBox();
            txtTelefonKontaktowy = new TextBox();
            txtEmail = new TextBox();
            btnZapisz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnPowrot
            // 
            btnPowrot.Location = new Point(654, 391);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(134, 47);
            btnPowrot.TabIndex = 0;
            btnPowrot.Text = "Anuluj";
            btnPowrot.UseVisualStyleBackColor = true;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(309, 12);
            txtNazwa.Multiline = true;
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(302, 48);
            txtNazwa.TabIndex = 1;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(309, 76);
            txtMiejscowosc.Multiline = true;
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(302, 48);
            txtMiejscowosc.TabIndex = 2;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(309, 140);
            txtKodPocztowy.Multiline = true;
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(302, 48);
            txtKodPocztowy.TabIndex = 3;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(309, 200);
            txtUlica.Multiline = true;
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(302, 48);
            txtUlica.TabIndex = 4;
            // 
            // txtTelefonKontaktowy
            // 
            txtTelefonKontaktowy.Location = new Point(309, 267);
            txtTelefonKontaktowy.Multiline = true;
            txtTelefonKontaktowy.Name = "txtTelefonKontaktowy";
            txtTelefonKontaktowy.Size = new Size(302, 48);
            txtTelefonKontaktowy.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(309, 331);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 48);
            txtEmail.TabIndex = 6;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(12, 391);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(134, 47);
            btnZapisz.TabIndex = 7;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 8;
            label1.Text = "Nazwa szkoły :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 92);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 9;
            label2.Text = "Miejscowość :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 155);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 10;
            label3.Text = "Kod pocztowy :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 215);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 11;
            label4.Text = "Ulica :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 279);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 12;
            label6.Text = "Telefon Kontatkowy :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 345);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 13;
            label7.Text = "Adres e-mail :";
            // 
            // EdytujDaneSzkoly
            // 
            AcceptButton = btnZapisz;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnZapisz);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefonKontaktowy);
            Controls.Add(txtUlica);
            Controls.Add(txtKodPocztowy);
            Controls.Add(txtMiejscowosc);
            Controls.Add(txtNazwa);
            Controls.Add(btnPowrot);
            Name = "EdytujDaneSzkoly";
            Text = "EdytujDaneSzkoly";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPowrot;
        private TextBox txtNazwa;
        private TextBox txtMiejscowosc;
        private TextBox txtKodPocztowy;
        private TextBox txtUlica;
        private TextBox txtTelefonKontaktowy;
        private TextBox txtEmail;
        private Button btnZapisz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}