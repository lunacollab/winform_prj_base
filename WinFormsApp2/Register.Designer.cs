namespace WinFormsApp2
{
    partial class Register
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
            pnlRegister = new Panel();
            pnlRegisterForm = new Panel();
            linkLogin = new LinkLabel();
            btnRegister = new Button();
            lbPassword = new Label();
            lbUsername = new Label();
            txbPassword = new TextBox();
            lbRegister = new Label();
            txbUsername = new TextBox();
            pnlPicture = new Panel();
            textBox1 = new TextBox();
            lbEmail = new Label();
            pnlRegister.SuspendLayout();
            pnlRegisterForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(pnlRegisterForm);
            pnlRegister.Location = new Point(2, 12);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(594, 487);
            pnlRegister.TabIndex = 2;
            // 
            // pnlRegisterForm
            // 
            pnlRegisterForm.Controls.Add(lbEmail);
            pnlRegisterForm.Controls.Add(textBox1);
            pnlRegisterForm.Controls.Add(linkLogin);
            pnlRegisterForm.Controls.Add(btnRegister);
            pnlRegisterForm.Controls.Add(lbPassword);
            pnlRegisterForm.Controls.Add(lbUsername);
            pnlRegisterForm.Controls.Add(txbPassword);
            pnlRegisterForm.Controls.Add(lbRegister);
            pnlRegisterForm.Controls.Add(txbUsername);
            pnlRegisterForm.Location = new Point(96, 3);
            pnlRegisterForm.Name = "pnlRegisterForm";
            pnlRegisterForm.Size = new Size(401, 481);
            pnlRegisterForm.TabIndex = 2;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLogin.Location = new Point(219, 400);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(148, 19);
            linkLogin.TabIndex = 7;
            linkLogin.TabStop = true;
            linkLogin.Text = "Bạn đã có tài khoản?";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 12F);
            btnRegister.Location = new Point(141, 336);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 43);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Times New Roman", 12F);
            lbPassword.Location = new Point(99, 247);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(82, 22);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Times New Roman", 12F);
            lbUsername.Location = new Point(99, 179);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(124, 22);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Tên đăng nhập";
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Times New Roman", 11F);
            txbPassword.Location = new Point(99, 272);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(215, 29);
            txbPassword.TabIndex = 2;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Times New Roman", 15F);
            lbRegister.Location = new Point(141, 49);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(104, 29);
            lbRegister.TabIndex = 0;
            lbRegister.Text = "Đăng Ký";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Times New Roman", 11F);
            txbUsername.Location = new Point(99, 204);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(215, 29);
            txbUsername.TabIndex = 1;
            // 
            // pnlPicture
            // 
            pnlPicture.Location = new Point(602, 15);
            pnlPicture.Name = "pnlPicture";
            pnlPicture.Size = new Size(570, 481);
            pnlPicture.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 11F);
            textBox1.Location = new Point(99, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 29);
            textBox1.TabIndex = 8;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Times New Roman", 12F);
            lbEmail.Location = new Point(99, 106);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(57, 22);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "Email";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 499);
            Controls.Add(pnlPicture);
            Controls.Add(pnlRegister);
            Name = "Register";
            Text = "Register";
            pnlRegister.ResumeLayout(false);
            pnlRegisterForm.ResumeLayout(false);
            pnlRegisterForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private Panel pnlRegisterForm;
        private LinkLabel linkLogin;
        private Button btnRegister;
        private Label lbPassword;
        private Label lbUsername;
        private TextBox txbPassword;
        private Label lbRegister;
        private TextBox txbUsername;
        private Panel pnlPicture;
        private TextBox textBox1;
        private Label lbEmail;
    }
}