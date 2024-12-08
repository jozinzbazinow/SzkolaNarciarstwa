namespace SzkolaNarciarstwa
{
    partial class ZarzadzajUzytkownikami
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
            btnUtworzKonto = new Button();
            btnPowrot = new Button();
            btnUsunKonto = new Button();
            btnChangePassword = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnUtworzKonto
            // 
            btnUtworzKonto.Anchor = AnchorStyles.None;
            btnUtworzKonto.Location = new Point(65, 152);
            btnUtworzKonto.Name = "btnUtworzKonto";
            btnUtworzKonto.Size = new Size(233, 63);
            btnUtworzKonto.TabIndex = 0;
            btnUtworzKonto.Text = "Utwórz konto służbowe";
            btnUtworzKonto.UseVisualStyleBackColor = true;
            btnUtworzKonto.Click += btnUtworzKonto_Click;
            // 
            // btnPowrot
            // 
            btnPowrot.Location = new Point(648, 364);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(139, 52);
            btnPowrot.TabIndex = 1;
            btnPowrot.Text = "Powrót do panelu administracyjnego";
            btnPowrot.UseVisualStyleBackColor = true;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // btnUsunKonto
            // 
            btnUsunKonto.Anchor = AnchorStyles.None;
            btnUsunKonto.Location = new Point(65, 244);
            btnUsunKonto.Name = "btnUsunKonto";
            btnUsunKonto.Size = new Size(233, 63);
            btnUsunKonto.TabIndex = 2;
            btnUsunKonto.Text = "Usuń konto";
            btnUsunKonto.UseVisualStyleBackColor = true;
            btnUsunKonto.Click += btnUsunKonto_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.Location = new Point(65, 335);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(233, 63);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Nadpisz hasło";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 468);
            panel1.TabIndex = 15;
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
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(211, 58);
            button1.TabIndex = 3;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(305, 25);
            label1.TabIndex = 0;
            label1.Text = "ZARZADZAJ UZYTKOWNIKAMI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChangePassword);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnUsunKonto);
            panel3.Controls.Add(btnUtworzKonto);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(211, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 468);
            panel3.TabIndex = 17;
            // 
            // ZarzadzajUzytkownikami
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnPowrot);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZarzadzajUzytkownikami";
            Text = "ZarzadzajUzytkownikami";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUtworzKonto;
        private Button btnPowrot;
        private Button btnUsunKonto;
        private Button btnChangePassword;
        private Panel panel2;
        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Panel panel3;
        private Button button1;
    }
}