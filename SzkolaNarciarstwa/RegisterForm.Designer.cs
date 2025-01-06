namespace SzkolaNarciarstwa
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
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
            btnSubmit = new Button();
            btnBack = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblPasswordRepeat = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(198, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(198, 140);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.Size = new Size(176, 23);
            txtPassword1.TabIndex = 5;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(198, 168);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(176, 23);
            txtPassword2.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(198, 209);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(88, 38);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Załóż konto";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(294, 209);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 38);
            btnBack.TabIndex = 8;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(84, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(84, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(40, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Hasło:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(84, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Location = new Point(84, 168);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.Size = new Size(84, 15);
            lblPasswordRepeat.TabIndex = 5;
            lblPasswordRepeat.Text = "Powtórz hasło:";
            // 
            // RegisterForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 281);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword1);
            Controls.Add(lblPasswordRepeat);
            Controls.Add(txtPassword2);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisterForm";
            Text = "Rejestracja";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPasswordRepeat;
    }
}