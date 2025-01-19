namespace SzkolaNarciarstwa
{
    partial class PrzywrocKurs
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
            btnPrzywroc = new Button();
            btnAnuluj = new Button();
            panel5 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKursy).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKursy
            // 
            dgvKursy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKursy.Location = new Point(267, 106);
            dgvKursy.Margin = new Padding(3, 2, 3, 2);
            dgvKursy.Name = "dgvKursy";
            dgvKursy.RowHeadersWidth = 51;
            dgvKursy.Size = new Size(487, 312);
            dgvKursy.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 46, 84);
            panel1.Controls.Add(btnPrzywroc);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(241, 429);
            panel1.TabIndex = 22;
            // 
            // btnPrzywroc
            // 
            btnPrzywroc.BackColor = Color.SeaGreen;
            btnPrzywroc.Dock = DockStyle.Top;
            btnPrzywroc.FlatStyle = FlatStyle.Popup;
            btnPrzywroc.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnPrzywroc.ForeColor = Color.Transparent;
            btnPrzywroc.Location = new Point(5, 63);
            btnPrzywroc.Name = "btnPrzywroc";
            btnPrzywroc.Size = new Size(231, 58);
            btnPrzywroc.TabIndex = 9;
            btnPrzywroc.Text = "Przywróć kurs";
            btnPrzywroc.UseVisualStyleBackColor = false;
            btnPrzywroc.Click += btnUsun_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.Maroon;
            btnAnuluj.Dock = DockStyle.Top;
            btnAnuluj.FlatStyle = FlatStyle.Popup;
            btnAnuluj.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnAnuluj.ForeColor = Color.Transparent;
            btnAnuluj.Location = new Point(5, 5);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(231, 58);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(241, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(525, 87);
            panel5.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 38);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "PRZYWRÓĆ KURS";
            // 
            // PrzywrocKurs
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 429);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(dgvKursy);
            Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PrzywrocKurs";
            Text = "Przywroc Kurs";
            ((System.ComponentModel.ISupportInitialize)dgvKursy).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKursy;
        private Button btnAnuluj;
        private Button btnPrzywroc;
        private Panel panel1;
        private Panel panel5;
        private Label label1;
    }
}