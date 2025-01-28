namespace BookStore
{
    partial class Authentication
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
            labelLogin = new Label();
            labelTenDangNhap = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelMatKhau = new Label();
            buttonLogin = new Button();
            labelAlert = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(12, 22);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(265, 38);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Đăng nhập hệ thống";
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Font = new Font("Segoe UI", 10F);
            labelTenDangNhap.Location = new Point(12, 142);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(140, 28);
            labelTenDangNhap.TabIndex = 1;
            labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 10F);
            textBoxUsername.Location = new Point(12, 173);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(390, 34);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.Location = new Point(12, 248);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(390, 34);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Font = new Font("Segoe UI", 10F);
            labelMatKhau.Location = new Point(12, 217);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new Size(94, 28);
            labelMatKhau.TabIndex = 3;
            labelMatKhau.Text = "Mật khẩu";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(12, 303);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(161, 51);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlert.ForeColor = Color.FromArgb(192, 0, 0);
            labelAlert.Location = new Point(12, 91);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 28);
            labelAlert.TabIndex = 6;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 444);
            Controls.Add(labelAlert);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(labelMatKhau);
            Controls.Add(textBoxUsername);
            Controls.Add(labelTenDangNhap);
            Controls.Add(labelLogin);
            Name = "Authentication";
            Text = "Đăng nhập";
            FormClosed += Authentication_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelTenDangNhap;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelMatKhau;
        private Button buttonLogin;
        private Label labelAlert;
    }
}