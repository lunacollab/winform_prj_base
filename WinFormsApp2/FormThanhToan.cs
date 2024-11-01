using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormThanhToan : Form
    {
        private Label lblName;
        private Label lblCMND;
        private Label lblAddressService;
        private Label lblAddressBill;
        private Label lblFee;
        private TextBox txtName;
        private TextBox txtCMND;
        private TextBox txtAddressService;
        private TextBox txtAddressBill;
        private Button btnPay;
        private Button btnPrintReceipt;

        public FormThanhToan()
        {
            InitializeComponent(); 

            this.Text = "Form Thanh Toán";
            this.Size = new Size(1195, 546);
            this.BackColor = Color.LightGray;

            lblName = new Label() { Text = "Tên khách hàng", Left = 20, Top = 20, Width = 150 };
            lblCMND = new Label() { Text = "Số CMND", Left = 20, Top = 80, Width = 150 };
            lblAddressService = new Label() { Text = "Địa chỉ cài đặt dịch vụ", Left = 20, Top = 140, Width = 150 };
            lblAddressBill = new Label() { Text = "Địa chỉ gửi hóa đơn", Left = 20, Top = 200, Width = 150 };
            lblFee = new Label() { Text = "Phí hòa mạng: 100,000 VNĐ", Left = 20, Top = 260, Width = 250 };

            txtName = new TextBox() { Left = 20, Top = 50, Width = 1150, Height = 30, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Arial", 12) };
            txtCMND = new TextBox() { Left = 20, Top = 110, Width = 1150, Height = 30, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Arial", 12) };
            txtAddressService = new TextBox() { Left = 20, Top = 170, Width = 1150, Height = 30, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Arial", 12) };
            txtAddressBill = new TextBox() { Left = 20, Top = 230, Width = 1150, Height = 30, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Arial", 12) };


            btnPay = new Button() { Text = "Thanh toán", Left = 20, Top = 300, Width = 150, Height = 40 };
            btnPrintReceipt = new Button() { Text = "In hóa đơn", Left = 200, Top = 300, Width = 150, Height = 40 };

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCMND);
            Controls.Add(txtCMND);
            Controls.Add(lblAddressService);
            Controls.Add(txtAddressService);
            Controls.Add(lblAddressBill);
            Controls.Add(txtAddressBill);
            Controls.Add(lblFee);
            Controls.Add(btnPay);
            Controls.Add(btnPrintReceipt);
        }
    }
}
