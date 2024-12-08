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
            btnBack = new Button();
            SuspendLayout();
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.Location = new Point(1, 0);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(798, 404);
            listBoxCourses.TabIndex = 0;
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.Location = new Point(228, 421);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(0, 20);
            lblTotalHours.TabIndex = 1;
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.AutoSize = true;
            lblTotalSalary.Location = new Point(500, 421);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(0, 20);
            lblTotalSalary.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1, 410);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // CzasPracy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblTotalSalary);
            Controls.Add(lblTotalHours);
            Controls.Add(listBoxCourses);
            Name = "CzasPracy";
            Text = "CzasPracy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCourses;
        private Label lblTotalHours;
        private Label lblTotalSalary;
        private Button btnBack;
    }
}