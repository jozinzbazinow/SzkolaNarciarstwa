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
            txtUsername.Location = new Point(180, 62);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(180, 188);
            txtPassword1.Margin = new Padding(3, 4, 3, 4);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.Size = new Size(200, 27);
            txtPassword1.TabIndex = 5;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(180, 225);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(200, 27);
            txtPassword2.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 125);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(180, 280);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 50);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Załóż konto";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(290, 280);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 188);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Hasło:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Location = new Point(50, 225);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.Size = new Size(104, 20);
            lblPasswordRepeat.TabIndex = 5;
            lblPasswordRepeat.Text = "Powtórz hasło:";
            // 
            // RegisterForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 375);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "Rejestracja";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblPasswordRepeat;
    }
}