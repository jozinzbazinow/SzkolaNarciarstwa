namespace SzkolaNarciarstwa
{
    partial class EdytujOferte
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
            btnDodajKurs = new Button();
            btnUsun = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDodajKurs
            // 
            btnDodajKurs.Anchor = AnchorStyles.None;
            btnDodajKurs.Location = new Point(325, 180);
            btnDodajKurs.Name = "btnDodajKurs";
            btnDodajKurs.Size = new Size(144, 51);
            btnDodajKurs.TabIndex = 1;
            btnDodajKurs.Text = "Dodaj kurs";
            btnDodajKurs.UseVisualStyleBackColor = true;
            btnDodajKurs.Click += btnDodajKurs_Click;
            // 
            // btnUsun
            // 
            btnUsun.Anchor = AnchorStyles.None;
            btnUsun.Location = new Point(325, 248);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(144, 51);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń kurs";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.None;
            btnEdit.Location = new Point(325, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 51);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edytuj cenę";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 46, 84);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(571, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 468);
            panel2.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(211, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 87);
            panel5.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 27);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 0;
            label2.Text = "EDYTUJ OFERTĘ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Size = new Size(211, 468);
            panel1.TabIndex = 19;
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
            btnBack.Size = new Size(201, 58);
            btnBack.TabIndex = 8;
            btnBack.Text = "Anuluj";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // EdytujOferte
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 468);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnEdit);
            Controls.Add(btnUsun);
            Controls.Add(btnDodajKurs);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EdytujOferte";
            Text = "EdytujOferte";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDodajKurs;
        private Button btnUsun;
        private Button btnEdit;
        private Panel panel2;
        private Panel panel5;
        private Label label2;
        private Panel panel1;
        private Button btnBack;
    }
}