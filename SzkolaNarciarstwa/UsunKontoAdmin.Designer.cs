namespace SzkolaNarciarstwa
{
    partial class UsunKontoAdmin
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
            dgvUzytkownicy = new DataGridView();
            panel1 = new Panel();
            btnUsun = new Button();
            btnBack = new Button();
            panel5 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUzytkownicy
            // 
            dgvUzytkownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUzytkownicy.Location = new Point(269, 104);
            dgvUzytkownicy.Margin = new Padding(3, 2, 3, 2);
            dgvUzytkownicy.Name = "dgvUzytkownicy";
            dgvUzytkownicy.RowHeadersWidth = 51;
            dgvUzytkownicy.Size = new Size(480, 314);
            dgvUzytkownicy.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnUsun);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 429);
            panel1.TabIndex = 23;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.SeaGreen;
            btnUsun.Dock = DockStyle.Top;
            btnUsun.FlatStyle = FlatStyle.Popup;
            btnUsun.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnUsun.ForeColor = Color.Transparent;
            btnUsun.Location = new Point(5, 63);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(231, 58);
            btnUsun.TabIndex = 9;
            btnUsun.Text = "Usuń konto";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click_1;
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
            btnBack.Click += btnBack_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(525, 87);
            panel5.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "USUŃ KONTO";
            // 
            // UsunKontoAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 429);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(dgvUzytkownicy);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsunKontoAdmin";
            Text = "UsunKontoAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Panel panel5;
        private Label label1;
        private DataGridView dgvUzytkownicy;
        private Panel panel1;
        private Button btnUsun;
    }
}