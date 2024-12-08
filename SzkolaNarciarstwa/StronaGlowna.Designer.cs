namespace SzkolaNarciarstwa
{
    partial class StronaGlowna
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StronaGlowna));
            btnRegister = new Button();
            btnLoginPracownik = new Button();
            btnLoginKursant = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BackgroundImage = (Image)resources.GetObject("btnRegister.BackgroundImage");
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRegister.Location = new Point(0, 175);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(126, 38);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Załóż konto";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnLoginPracownik
            // 
            btnLoginPracownik.BackColor = Color.Transparent;
            btnLoginPracownik.BackgroundImage = (Image)resources.GetObject("btnLoginPracownik.BackgroundImage");
            btnLoginPracownik.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoginPracownik.Cursor = Cursors.Hand;
            btnLoginPracownik.FlatAppearance.BorderSize = 0;
            btnLoginPracownik.FlatStyle = FlatStyle.Flat;
            btnLoginPracownik.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLoginPracownik.Location = new Point(0, 94);
            btnLoginPracownik.Name = "btnLoginPracownik";
            btnLoginPracownik.Size = new Size(126, 48);
            btnLoginPracownik.TabIndex = 1;
            btnLoginPracownik.Text = "Zaloguj jako Pracownik";
            btnLoginPracownik.UseVisualStyleBackColor = false;
            // 
            // btnLoginKursant
            // 
            btnLoginKursant.BackColor = Color.Transparent;
            btnLoginKursant.BackgroundImage = (Image)resources.GetObject("btnLoginKursant.BackgroundImage");
            btnLoginKursant.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoginKursant.Cursor = Cursors.Hand;
            btnLoginKursant.FlatAppearance.BorderSize = 0;
            btnLoginKursant.FlatStyle = FlatStyle.Flat;
            btnLoginKursant.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLoginKursant.ForeColor = Color.Black;
            btnLoginKursant.Location = new Point(0, 11);
            btnLoginKursant.Margin = new Padding(3, 2, 3, 2);
            btnLoginKursant.Name = "btnLoginKursant";
            btnLoginKursant.Size = new Size(126, 50);
            btnLoginKursant.TabIndex = 0;
            btnLoginKursant.Text = "Zaloguj jako Kursant";
            btnLoginKursant.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 225);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(100, 255, 255, 255);
            panel4.Controls.Add(btnRegister);
            panel4.Controls.Add(btnLoginPracownik);
            panel4.Controls.Add(btnLoginKursant);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(112, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(126, 225);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(238, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(112, 225);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 225);
            panel2.TabIndex = 2;
            // 
            // StronaGlowna
            // 
            AcceptButton = btnLoginKursant;
            AccessibleName = "Panel Główny";
            AccessibleRole = AccessibleRole.Window;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(350, 225);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StronaGlowna";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Strona Główna - Szkoła Narciarstwa";
            Load += StronaGlowna_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button btnRegister;
        private Button btnLoginPracownik;
        private Button btnLoginKursant;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
    }
}