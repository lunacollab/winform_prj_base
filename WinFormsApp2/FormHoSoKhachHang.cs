using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormHoSoKhachHang : Form
    {
        public FormHoSoKhachHang()
        {
            InitializeComponent();
            this.Text = "Hồ Sơ Khách Hàng";
            this.Size = new Size(1195, 546);

            InitializeControls();
        }

        private void InitializeControls()
        {
            Label lblName = new Label() { Text = "Tên Khách Hàng", Top = 20, Left = 20 };
            TextBox txtName = new TextBox() { Top = 20, Left = 150, Width = 200 };

            Label lblCMND = new Label() { Text = "Số CMND", Top = 60, Left = 20 };
            TextBox txtCMND = new TextBox() { Top = 60, Left = 150, Width = 200 };

            Label lblAddress = new Label() { Text = "Địa Chỉ", Top = 100, Left = 20 };
            TextBox txtAddress = new TextBox() { Top = 100, Left = 150, Width = 200 };

            Label lblRegistrationStatus = new Label() { Text = "Tình Trạng Đăng Ký", Top = 140, Left = 20 };
            TextBox txtRegistrationStatus = new TextBox() { Top = 140, Left = 150, Width = 200 };

            Label lblPaymentStatus = new Label() { Text = "Tình Trạng Thanh Toán", Top = 180, Left = 20 };
            TextBox txtPaymentStatus = new TextBox() { Top = 180, Left = 150, Width = 200 };

            Button btnSave = new Button() { Text = "Lưu Hồ Sơ", Top = 220, Left = 150 };
            btnSave.Click += (sender, e) => { SaveCustomerProfile(txtName.Text, txtCMND.Text, txtAddress.Text, txtRegistrationStatus.Text, txtPaymentStatus.Text); };

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCMND);
            Controls.Add(txtCMND);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblRegistrationStatus);
            Controls.Add(txtRegistrationStatus);
            Controls.Add(lblPaymentStatus);
            Controls.Add(txtPaymentStatus);
            Controls.Add(btnSave);
        }

        private void SaveCustomerProfile(string name, string cmnd, string address, string registrationStatus, string paymentStatus)
        {
            MessageBox.Show($"Lưu hồ sơ thành công cho {name} với số CMND {cmnd}.");
        }
    }
}
