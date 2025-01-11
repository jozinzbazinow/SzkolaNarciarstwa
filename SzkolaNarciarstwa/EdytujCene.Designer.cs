namespace SzkolaNarciarstwa
{
    partial class EdytujCene
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
            dgvKursy = new DataGridView();
            panel1 = new Panel();
            btnCenaEdit = new Button();
            btnAnuluj = new Button();
            panel5 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKursy).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKursy
            // 
            dgvKursy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKursy.Location = new Point(268, 120);
            dgvKursy.Name = "dgvKursy";
            dgvKursy.RowHeadersWidth = 51;
            dgvKursy.Size = new Size(482, 314);
            dgvKursy.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnCenaEdit);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 468);
            panel1.TabIndex = 21;
            // 
            // btnCenaEdit
            // 
            btnCenaEdit.BackColor = Color.SeaGreen;
            btnCenaEdit.Dock = DockStyle.Top;
            btnCenaEdit.FlatStyle = FlatStyle.Popup;
            btnCenaEdit.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnCenaEdit.ForeColor = Color.Transparent;
            btnCenaEdit.Location = new Point(5, 63);
            btnCenaEdit.Margin = new Padding(3, 4, 3, 4);
            btnCenaEdit.Name = "btnCenaEdit";
            btnCenaEdit.Size = new Size(231, 58);
            btnCenaEdit.TabIndex = 9;
            btnCenaEdit.Text = "Zmień cenę";
            btnCenaEdit.UseVisualStyleBackColor = false;
            btnCenaEdit.Click += btnCenaEdit_Click_1;
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.Maroon;
            btnAnuluj.Dock = DockStyle.Top;
            btnAnuluj.FlatStyle = FlatStyle.Popup;
            btnAnuluj.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnAnuluj.ForeColor = Color.Transparent;
            btnAnuluj.Location = new Point(5, 5);
            btnAnuluj.Margin = new Padding(3, 4, 3, 4);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(231, 58);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(541, 87);
            panel5.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 37);
            label6.Name = "label6";
            label6.Size = new Size(206, 25);
            label6.TabIndex = 0;
            label6.Text = "EDYTUJ CENĘ KURSU";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EdytujCene
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(dgvKursy);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EdytujCene";
            Text = "EdytujCene";
            ((System.ComponentModel.ISupportInitialize)dgvKursy).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKursy;
        private Button btnAnuluj;
        private Panel panel5;
        private Label label6;
        private Button btnCenaEdit;
        private Panel panel1;
    }
}