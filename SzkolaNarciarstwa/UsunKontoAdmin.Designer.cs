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
            btnBack = new Button();
            btnUsun = new Button();
            dgvUzytkownicy = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(397, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(219, 51);
            btnBack.TabIndex = 0;
            btnBack.Text = "Powrót do zarządzania użytkownikami";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(140, 394);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(193, 51);
            btnUsun.TabIndex = 1;
            btnUsun.Text = "Usuń wybrane konto(a)";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // dgvUzytkownicy
            // 
            dgvUzytkownicy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUzytkownicy.Location = new Point(29, 26);
            dgvUzytkownicy.Name = "dgvUzytkownicy";
            dgvUzytkownicy.RowHeadersWidth = 51;
            dgvUzytkownicy.Size = new Size(654, 362);
            dgvUzytkownicy.TabIndex = 2;
            // 
            // UsunKontoAdmin
            // 
            AcceptButton = btnUsun;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUzytkownicy);
            Controls.Add(btnUsun);
            Controls.Add(btnBack);
            Name = "UsunKontoAdmin";
            Text = "UsunKontoAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvUzytkownicy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnUsun;
        private DataGridView dgvUzytkownicy;
    }
}