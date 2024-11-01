using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormCapNhatTaiKhoan : Form
    {
        public FormCapNhatTaiKhoan()
        {
            InitializeComponent();
            this.Text = "Cập Nhật Tài Khoản";
            this.Size = new Size(1195, 546);

            InitializeControls();
        }

        private void InitializeControls()
        {
            Label lblCurrentAccount = new Label() { Text = "Tài Khoản Hiện Tại", Top = 20, Left = 20 };
            TextBox txtCurrentAccount = new TextBox() { Top = 20, Left = 150, Width = 200 };

            Label lblNewAccount = new Label() { Text = "Số Tài Khoản Mới", Top = 60, Left = 20 };
            TextBox txtNewAccount = new TextBox() { Top = 60, Left = 150, Width = 200 };

            Button btnUpdate = new Button() { Text = "Cập Nhật", Top = 100, Left = 150 };
            btnUpdate.Click += (sender, e) => { UpdateAccount(txtCurrentAccount.Text, txtNewAccount.Text); };

            Controls.Add(lblCurrentAccount);
            Controls.Add(txtCurrentAccount);
            Controls.Add(lblNewAccount);
            Controls.Add(txtNewAccount);
            Controls.Add(btnUpdate);
        }

        private void UpdateAccount(string currentAccount, string newAccount)
        {
            MessageBox.Show($"Cập nhật tài khoản: từ {currentAccount} sang {newAccount} thành công.");
        }
    }
}
