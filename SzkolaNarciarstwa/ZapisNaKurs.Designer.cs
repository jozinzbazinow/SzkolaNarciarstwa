namespace SzkolaNarciarstwa
{
    partial class ZapisNaKurs
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
            cmbKursy = new ComboBox();
            cmbTerminy = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnZapisz = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cmbKursy
            // 
            cmbKursy.Anchor = AnchorStyles.None;
            cmbKursy.FormattingEnabled = true;
            cmbKursy.Location = new Point(284, 190);
            cmbKursy.Name = "cmbKursy";
            cmbKursy.Size = new Size(218, 27);
            cmbKursy.TabIndex = 0;
            cmbKursy.SelectedIndexChanged += cmbKursy_SelectedIndexChanged;
            // 
            // cmbTerminy
            // 
            cmbTerminy.Anchor = AnchorStyles.None;
            cmbTerminy.FormattingEnabled = true;
            cmbTerminy.Location = new Point(284, 308);
            cmbTerminy.Name = "cmbTerminy";
            cmbTerminy.Size = new Size(218, 27);
            cmbTerminy.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(343, 168);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 2;
            label1.Text = "Nazwa kursu :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(341, 286);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 3;
            label2.Text = "Termin kursu :";
            // 
            // btnZapisz
            // 
            btnZapisz.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnZapisz.BackColor = Color.FromArgb(48, 46, 100);
            btnZapisz.BackgroundImageLayout = ImageLayout.None;
            btnZapisz.Cursor = Cursors.Hand;
            btnZapisz.Dock = DockStyle.Top;
            btnZapisz.FlatAppearance.BorderSize = 0;
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnZapisz.ForeColor = Color.Transparent;
            btnZapisz.Location = new Point(0, 0);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(211, 58);
            btnZapisz.TabIndex = 4;
            btnZapisz.Text = "Zapisz się";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnZapisz);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 468);
            panel1.TabIndex = 16;
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
            button1.TabIndex = 5;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(211, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 32);
            label3.Name = "label3";
            label3.Size = new Size(203, 25);
            label3.TabIndex = 0;
            label3.Text = "ZAPISZ SIĘ NA KURS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(211, 420);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 48);
            panel3.TabIndex = 18;
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
            label4.Text = "Aby zapisać się na kurs najpierw wybierz nazwę kursu, a następnie jego termin";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ZapisNaKurs
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTerminy);
            Controls.Add(cmbKursy);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZapisNaKurs";
            Text = "ZapisNaKurs";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKursy;
        private ComboBox cmbTerminy;
        private Label label1;
        private Label label2;
        private Button btnZapisz;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Panel panel5;
        private Label label3;
        private Panel panel3;
        private Label label4;
    }
}