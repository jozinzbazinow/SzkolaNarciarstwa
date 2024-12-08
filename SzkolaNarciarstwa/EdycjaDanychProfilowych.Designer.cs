namespace SzkolaNarciarstwa
{
    partial class EdycjaDanychProfilowych
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
            txtNumer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnZapisz = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            lblKomunikat = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Anchor = AnchorStyles.None;
            txtImie.Location = new Point(54, 134);
            txtImie.Multiline = true;
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(240, 32);
            txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Anchor = AnchorStyles.None;
            txtNazwisko.Location = new Point(54, 196);
            txtNazwisko.Multiline = true;
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(240, 32);
            txtNazwisko.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(54, 258);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 32);
            txtEmail.TabIndex = 2;
            // 
            // txtNumer
            // 
            txtNumer.Anchor = AnchorStyles.None;
            txtNumer.Location = new Point(54, 315);
            txtNumer.Multiline = true;
            txtNumer.Name = "txtNumer";
            txtNumer.Size = new Size(240, 32);
            txtNumer.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(54, 112);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 5;
            label1.Text = "Imie : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(54, 174);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 6;
            label2.Text = "Nazwisko : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(54, 293);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 7;
            label3.Text = "Numer tel. : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(54, 235);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 8;
            label4.Text = "Adres e-mail: ";
            // 
            // BtnZapisz
            // 
            BtnZapisz.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnZapisz.BackColor = Color.FromArgb(48, 46, 100);
            BtnZapisz.Cursor = Cursors.Hand;
            BtnZapisz.Dock = DockStyle.Top;
            BtnZapisz.FlatAppearance.BorderSize = 0;
            BtnZapisz.FlatStyle = FlatStyle.Flat;
            BtnZapisz.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            BtnZapisz.ForeColor = Color.Transparent;
            BtnZapisz.Location = new Point(0, 0);
            BtnZapisz.Name = "BtnZapisz";
            BtnZapisz.Size = new Size(211, 58);
            BtnZapisz.TabIndex = 10;
            BtnZapisz.Text = "Zapisz";
            BtnZapisz.UseVisualStyleBackColor = false;
            BtnZapisz.Click += BtnZapisz_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(54, 360);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 12;
            label5.Text = "Data urodzenia : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dateTimePicker1.Location = new Point(54, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnZapisz);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 468);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(48, 46, 100);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(0, 58);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(211, 58);
            button1.TabIndex = 11;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblKomunikat);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(txtImie);
            panel3.Controls.Add(txtNumer);
            panel3.Controls.Add(txtNazwisko);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(211, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 468);
            panel3.TabIndex = 18;
            // 
            // lblKomunikat
            // 
            lblKomunikat.AutoSize = true;
            lblKomunikat.Location = new Point(176, 440);
            lblKomunikat.Name = "lblKomunikat";
            lblKomunikat.Size = new Size(0, 19);
            lblKomunikat.TabIndex = 19;
            lblKomunikat.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 33);
            label6.Name = "label6";
            label6.Size = new Size(259, 25);
            label6.TabIndex = 0;
            label6.Text = "EDYTUJ DANE PROFILOWE";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EdycjaDanychProfilowych
            // 
            AcceptButton = BtnZapisz;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EdycjaDanychProfilowych";
            Text = "EdycjaDanychProfilowych";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtEmail;
        private TextBox txtNumer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnZapisz;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private Button button1;
        private Label lblKomunikat;
    }
}