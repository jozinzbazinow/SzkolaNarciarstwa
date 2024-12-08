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
            btnAnuluj = new Button();
            btnCenaEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKursy).BeginInit();
            SuspendLayout();
            // 
            // dgvKursy
            // 
            dgvKursy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKursy.Location = new Point(0, -1);
            dgvKursy.Name = "dgvKursy";
            dgvKursy.RowHeadersWidth = 51;
            dgvKursy.Size = new Size(632, 451);
            dgvKursy.TabIndex = 1;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(649, 383);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(139, 55);
            btnAnuluj.TabIndex = 2;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // btnCenaEdit
            // 
            btnCenaEdit.Location = new Point(649, 187);
            btnCenaEdit.Name = "btnCenaEdit";
            btnCenaEdit.Size = new Size(139, 55);
            btnCenaEdit.TabIndex = 3;
            btnCenaEdit.Text = "Zmień cenę";
            btnCenaEdit.UseVisualStyleBackColor = true;
            btnCenaEdit.Click += btnCenaEdit_Click;
            // 
            // EdytujCene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCenaEdit);
            Controls.Add(btnAnuluj);
            Controls.Add(dgvKursy);
            Name = "EdytujCene";
            Text = "EdytujCene";
            ((System.ComponentModel.ISupportInitialize)dgvKursy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKursy;
        private Button btnAnuluj;
        private Button btnCenaEdit;
    }
}