using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormThongTinTaiKhoan : Form
    {
        private Label lblName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnSendInfo;
        private Button btnChangePassword;
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
            this.Text = "Form Thông Tin Tài Khoản";
            this.Size = new System.Drawing.Size(1195, 546);

            lblName = new Label() { Text = "Tên khách hàng", Left = 20, Top = 20, Width = 1150 };
            lblUsername = new Label() { Text = "Tên đăng nhập", Left = 20, Top = 60, Width = 1150 };
            lblPassword = new Label() { Text = "Mật khẩu", Left = 20, Top = 100, Width = 1150 };
            lblEmail = new Label() { Text = "Email", Left = 20, Top = 140, Width = 1150 };
            btnSendInfo = new Button() { Text = "Gửi thông tin", Left = 20, Top = 180, Width = 150, Height = 40 };
            btnChangePassword = new Button() { Text = "Đổi mật khẩu", Left = 200, Top = 180, Width = 150, Height = 40 };

            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnSendInfo);
            Controls.Add(btnChangePassword);
            
        }
    }
}
