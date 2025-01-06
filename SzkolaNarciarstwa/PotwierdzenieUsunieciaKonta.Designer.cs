namespace SzkolaNarciarstwa
{
    partial class PotwierdzenieUsunieciaKonta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHaslo = new TextBox();
            label1 = new Label();
            btnPotwierdz = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtHaslo
            // 
            txtHaslo.Anchor = AnchorStyles.None;
            txtHaslo.Location = new Point(120, 237);
            txtHaslo.Multiline = true;
            txtHaslo.Name = "txtHaslo";
            txtHaslo.RightToLeft = RightToLeft.No;
            txtHaslo.Size = new Size(125, 32);
            txtHaslo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(120, 205);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 1;
            label1.Text = "Wprowadz hasło:";
            // 
            // btnPotwierdz
            // 
            btnPotwierdz.BackColor = Color.Maroon;
            btnPotwierdz.Cursor = Cursors.Hand;
            btnPotwierdz.Dock = DockStyle.Top;
            btnPotwierdz.FlatAppearance.BorderSize = 0;
            btnPotwierdz.FlatStyle = FlatStyle.Popup;
            btnPotwierdz.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnPotwierdz.ForeColor = Color.Transparent;
            btnPotwierdz.Location = new Point(5, 5);
            btnPotwierdz.Name = "btnPotwierdz";
            btnPotwierdz.Size = new Size(201, 58);
            btnPotwierdz.TabIndex = 3;
            btnPotwierdz.Text = "Potwierdź usunięcie konta";
            btnPotwierdz.UseVisualStyleBackColor = false;
            btnPotwierdz.Click += BtnPotwierdz_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPotwierdz);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(211, 468);
            panel1.TabIndex = 18;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(48, 46, 100);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(5, 63);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 58);
            button1.TabIndex = 12;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtHaslo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(211, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 468);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 420);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 48);
            panel4.TabIndex = 20;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Help;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(356, 44);
            label4.TabIndex = 0;
            label4.Text = "Po usunięciu konta, wszystkie Twoje dane zostaną trwale usunięte.\r\nUwaga: Usunięcie konta jest nieodwracalne.\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkRed;
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 33);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 0;
            label6.Text = "USUŃ KONTO";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PotwierdzenieUsunieciaKonta
            // 
            AcceptButton = btnPotwierdz;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(782, 468);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PotwierdzenieUsunieciaKonta";
            Text = "PotwierdzenieUsunieciaKonta";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtHaslo;
        private Label label1;
        private Button btnPotwierdz;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private Panel panel4;
        private Label label4;
    }
}