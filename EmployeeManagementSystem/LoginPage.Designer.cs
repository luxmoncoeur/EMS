namespace EmployeeManagementSystem
{
    partial class LoginPage
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
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic", 87.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(70, 130, 169);
            lblTitle.Location = new Point(327, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 151);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EMS";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15F);
            txtUsername.Location = new Point(237, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(561, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(237, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(561, 34);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(33, 52, 72);
            lblUsername.Location = new Point(148, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(33, 52, 72);
            lblPassword.Location = new Point(148, 235);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(33, 52, 72);
            btnLogin.Location = new Point(654, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(940, 404);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblTitle);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
    }
}