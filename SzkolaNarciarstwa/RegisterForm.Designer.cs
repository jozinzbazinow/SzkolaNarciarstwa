namespace SzkolaNarciarstwa
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            txtEmail = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblPasswordRepeat = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(255, 52);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(225, 22);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(255, 133);
            txtPassword1.Margin = new Padding(4, 3, 4, 3);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.Size = new Size(225, 22);
            txtPassword1.TabIndex = 5;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(255, 171);
            txtPassword2.Margin = new Padding(4, 3, 4, 3);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(225, 22);
            txtPassword2.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 93);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 22);
            txtEmail.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(81, 52);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(151, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(179, 133);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(53, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Hasło:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(184, 93);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Location = new Point(116, 171);
            lblPasswordRepeat.Margin = new Padding(4, 0, 4, 0);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.Size = new Size(116, 15);
            lblPasswordRepeat.TabIndex = 5;
            lblPasswordRepeat.Text = "Powtórz hasło:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(55, 54, 100);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(255, 209);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 38);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Zarejestruj";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(55, 54, 100);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(390, 209);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 38);
            btnBack.TabIndex = 10;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 54, 74);
            ClientSize = new Size(597, 281);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword1);
            Controls.Add(lblPasswordRepeat);
            Controls.Add(txtPassword2);
            Font = new Font("MS UI Gothic", 11.25F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            Text = "Rejestracja";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPasswordRepeat;
        private Button btnSubmit;
        private Button btnBack;
    }
}