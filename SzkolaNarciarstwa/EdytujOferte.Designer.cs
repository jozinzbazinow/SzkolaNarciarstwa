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
            btnBack = new Button();
            btnDodajKurs = new Button();
            btnUsun = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(648, 376);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 62);
            btnBack.TabIndex = 0;
            btnBack.Text = "Powrót do panelu użytkownika";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDodajKurs
            // 
            btnDodajKurs.Location = new Point(323, 123);
            btnDodajKurs.Name = "btnDodajKurs";
            btnDodajKurs.Size = new Size(144, 53);
            btnDodajKurs.TabIndex = 1;
            btnDodajKurs.Text = "Dodaj kurs";
            btnDodajKurs.UseVisualStyleBackColor = true;
            btnDodajKurs.Click += btnDodajKurs_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(323, 194);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(144, 53);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń kurs";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(323, 265);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 53);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edytuj cenę";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EdytujOferte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnUsun);
            Controls.Add(btnDodajKurs);
            Controls.Add(btnBack);
            Name = "EdytujOferte";
            Text = "EdytujOferte";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnDodajKurs;
        private Button btnUsun;
        private Button btnEdit;
    }
}