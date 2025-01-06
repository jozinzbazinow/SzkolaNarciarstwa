namespace SzkolaNarciarstwa
{
    partial class CzasPracy
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
            listBoxCourses = new ListBox();
            lblTotalHours = new Label();
            lblTotalSalary = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxCourses
            // 
            listBoxCourses.Anchor = AnchorStyles.None;
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.Location = new Point(267, 108);
            listBoxCourses.Margin = new Padding(3, 2, 3, 2);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(489, 349);
            listBoxCourses.TabIndex = 0;
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.Location = new Point(200, 316);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(0, 15);
            lblTotalHours.TabIndex = 1;
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.AutoSize = true;
            lblTotalSalary.Location = new Point(438, 316);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(0, 15);
            lblTotalSalary.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 468);
            panel1.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.Dock = DockStyle.Top;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 58);
            btnBack.TabIndex = 0;
            btnBack.Text = "Anuluj";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 87);
            panel5.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "CZAS PRACY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // CzasPracy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(lblTotalSalary);
            Controls.Add(lblTotalHours);
            Controls.Add(listBoxCourses);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CzasPracy";
            Text = "CzasPracy";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCourses;
        private Label lblTotalHours;
        private Label lblTotalSalary;
        private Panel panel1;
        private Button btnBack;
        private Panel panel5;
        private Label label1;
    }
}