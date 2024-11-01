namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPicture = new Panel();
            pnlLogin = new Panel();
            pnlLoginForm = new Panel();
            linkRegister = new LinkLabel();
            btnLogin = new Button();
            cbxSavePw = new CheckBox();
            lbPassword = new Label();
            lbUsername = new Label();
            txbPassword = new TextBox();
            lbLogin = new Label();
            txbUsername = new TextBox();
            pnlLogin.SuspendLayout();
            pnlLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPicture
            // 
            pnlPicture.Location = new Point(603, 2);
            pnlPicture.Name = "pnlPicture";
            pnlPicture.Size = new Size(570, 487);
            pnlPicture.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(pnlLoginForm);
            pnlLogin.Location = new Point(3, 2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(594, 487);
            pnlLogin.TabIndex = 1;
            // 
            // pnlLoginForm
            // 
            pnlLoginForm.Controls.Add(linkRegister);
            pnlLoginForm.Controls.Add(btnLogin);
            pnlLoginForm.Controls.Add(cbxSavePw);
            pnlLoginForm.Controls.Add(lbPassword);
            pnlLoginForm.Controls.Add(lbUsername);
            pnlLoginForm.Controls.Add(txbPassword);
            pnlLoginForm.Controls.Add(lbLogin);
            pnlLoginForm.Controls.Add(txbUsername);
            pnlLoginForm.Location = new Point(96, 3);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new Size(401, 481);
            pnlLoginForm.TabIndex = 2;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.Location = new Point(219, 400);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(164, 19);
            linkRegister.TabIndex = 7;
            linkRegister.TabStop = true;
            linkRegister.Text = "Bạn chưa có tài khoản?";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 12F);
            btnLogin.Location = new Point(126, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 43);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // cbxSavePw
            // 
            cbxSavePw.AutoSize = true;
            cbxSavePw.Font = new Font("Times New Roman", 11F);
            cbxSavePw.Location = new Point(100, 288);
            cbxSavePw.Name = "cbxSavePw";
            cbxSavePw.Size = new Size(134, 25);
            cbxSavePw.TabIndex = 5;
            cbxSavePw.Text = "Lưu mật khẩu";
            cbxSavePw.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Times New Roman", 12F);
            lbPassword.Location = new Point(100, 215);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(82, 22);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Times New Roman", 12F);
            lbUsername.Location = new Point(99, 150);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(124, 22);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Tên đăng nhập";
            lbUsername.Click += label1_Click_1;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Times New Roman", 11F);
            txbPassword.Location = new Point(100, 239);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(215, 29);
            txbPassword.TabIndex = 2;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Times New Roman", 15F);
            lbLogin.Location = new Point(128, 80);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(128, 29);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Đăng Nhập";
            lbLogin.Click += label1_Click;
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Times New Roman", 11F);
            txbUsername.Location = new Point(100, 174);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(215, 29);
            txbUsername.TabIndex = 1;
            txbUsername.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 501);
            Controls.Add(pnlLogin);
            Controls.Add(pnlPicture);
            Name = "Form1";
            Text = "Form1";
            pnlLogin.ResumeLayout(false);
            pnlLoginForm.ResumeLayout(false);
            pnlLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPicture;
        private Panel pnlLogin;
        private Label lbLogin;
        private TextBox txbUsername;
        private Panel pnlLoginForm;
        private TextBox txbPassword;
        private Label lbPassword;
        private Label lbUsername;
        private CheckBox cbxSavePw;
        private Button btnLogin;
        private LinkLabel linkRegister;
    }
}
