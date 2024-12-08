namespace SzkolaNarciarstwa
{
    partial class AnulujKurs
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
            listBoxKursy = new ListBox();
            btnAnulujKurs = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxKursy
            // 
            listBoxKursy.Anchor = AnchorStyles.None;
            listBoxKursy.FormattingEnabled = true;
            listBoxKursy.Location = new Point(30, 148);
            listBoxKursy.Name = "listBoxKursy";
            listBoxKursy.Size = new Size(300, 308);
            listBoxKursy.TabIndex = 0;
            // 
            // btnAnulujKurs
            // 
            btnAnulujKurs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAnulujKurs.BackColor = Color.FromArgb(48, 46, 100);
            btnAnulujKurs.Cursor = Cursors.Hand;
            btnAnulujKurs.Dock = DockStyle.Top;
            btnAnulujKurs.FlatAppearance.BorderSize = 0;
            btnAnulujKurs.FlatStyle = FlatStyle.Flat;
            btnAnulujKurs.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnAnulujKurs.ForeColor = Color.Transparent;
            btnAnulujKurs.Location = new Point(0, 0);
            btnAnulujKurs.Name = "btnAnulujKurs";
            btnAnulujKurs.Size = new Size(211, 71);
            btnAnulujKurs.TabIndex = 1;
            btnAnulujKurs.Text = "Anuluj wybrany kurs";
            btnAnulujKurs.UseVisualStyleBackColor = false;
            btnAnulujKurs.Click += btnAnulujKurs_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAnulujKurs);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
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
            button1.Location = new Point(0, 71);
            button1.Name = "button1";
            button1.Size = new Size(211, 58);
            button1.TabIndex = 4;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(listBoxKursy);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(211, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 468);
            panel3.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "ANULACJA KURSU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnulujKurs
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnulujKurs";
            Text = "AnulujKurs";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxKursy;
        private Button btnAnulujKurs;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private Label label1;
    }
}