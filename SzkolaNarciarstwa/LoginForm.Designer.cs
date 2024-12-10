namespace SzkolaNarciarstwa
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

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
            txtPassword = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.InactiveCaption;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            txtUsername.Location = new Point(157, 46);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(225, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            txtPassword.Location = new Point(157, 94);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(225, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(55, 54, 100);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(157, 150);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 38);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Zaloguj się";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(55, 54, 100);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(293, 150);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(77, 48);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(55, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Login:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(77, 96);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Hasło:";
            lblPassword.Click += lblPassword_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(9F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(55, 54, 74);
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = btnBack;
            ClientSize = new Size(464, 234);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Font = new Font("MS UI Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(381, 200);
            Name = "LoginForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}