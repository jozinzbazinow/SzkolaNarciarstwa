namespace SzkolaNarciarstwa
{
    partial class DodajKurs
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
            btnAnuluj = new Button();
            txtNazwa = new TextBox();
            txtOpis = new TextBox();
            txtCena = new TextBox();
            cmbPoziom = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnZatwierdz = new Button();
            SuspendLayout();
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(653, 384);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(135, 54);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtNazwa
            // 
            txtNazwa.Location = new Point(309, 72);
            txtNazwa.Multiline = true;
            txtNazwa.Name = "txtNazwa";
            txtNazwa.Size = new Size(203, 49);
            txtNazwa.TabIndex = 1;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(309, 141);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(203, 49);
            txtOpis.TabIndex = 2;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(309, 209);
            txtCena.Multiline = true;
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(203, 49);
            txtCena.TabIndex = 3;
            // 
            // cmbPoziom
            // 
            cmbPoziom.FormattingEnabled = true;
            cmbPoziom.Items.AddRange(new object[] { "Początkujący", "Średnio-zaawansowany", "Zaawansowany", "Ekspert" });
            cmbPoziom.Location = new Point(309, 288);
            cmbPoziom.Name = "cmbPoziom";
            cmbPoziom.Size = new Size(203, 28);
            cmbPoziom.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Nazwa kursu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 156);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "Opis kursu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 224);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Cena :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 291);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 8;
            label4.Text = "Poziom zaaw. :";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(587, 156);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(153, 75);
            btnZatwierdz.TabIndex = 9;
            btnZatwierdz.Text = "Zatwierdź wprowadzony kurs";
            btnZatwierdz.UseVisualStyleBackColor = true;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // DodajKurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZatwierdz);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPoziom);
            Controls.Add(txtCena);
            Controls.Add(txtOpis);
            Controls.Add(txtNazwa);
            Controls.Add(btnAnuluj);
            Name = "DodajKurs";
            Text = "DodajKurs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnuluj;
        private TextBox txtNazwa;
        private TextBox txtOpis;
        private TextBox txtCena;
        private ComboBox cmbPoziom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnZatwierdz;
    }
}