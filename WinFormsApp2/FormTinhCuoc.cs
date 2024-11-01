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
    public partial class FormTinhCuoc : Form
    {
        private Label lblSubscriptionFee;
        private Label lblUsage;
        private Label lblRates;
        private Label lblTotal;
        private TextBox txtUsage;
        private TextBox txtTotal;  
        private Button btnCalculate;
        private Button btnPrintInvoice;

        public FormTinhCuoc()
        {
            InitializeComponent();
            this.Text = "Form Tính Cước và Thanh Toán Hàng Tháng";
            this.Size = new System.Drawing.Size(1195, 546);

            lblSubscriptionFee = new Label() { Text = "Cước thuê bao tháng: 50,000 VNĐ", Left = 20, Top = 20, Width = 1150 };
            lblUsage = new Label() { Text = "Số phút sử dụng", Left = 20, Top = 60, Width = 1150 };
            lblRates = new Label() { Text = "Giá cước ngày/đêm: 80đ/phút, 40đ/phút", Left = 20, Top = 100, Width = 1150 };
            lblTotal = new Label() { Text = "Tổng cước phí: ", Left = 20, Top = 140, Width = 1150 };

    
            txtUsage = new TextBox() { Left = 150, Top = 60, Width = 100 };

        
            txtTotal = new TextBox() { Left = 150, Top = 140, Width = 100, ReadOnly = true };

            btnCalculate = new Button() { Text = "Tính cước", Left = 20, Top = 180, Width = 150, Height = 40 };
            btnPrintInvoice = new Button() { Text = "In hóa đơn", Left = 200, Top = 180, Width = 150, Height = 40 };

            Controls.Add(lblSubscriptionFee);
            Controls.Add(lblUsage);
            Controls.Add(txtUsage);  
            Controls.Add(lblRates);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal); 
            Controls.Add(btnCalculate);
            Controls.Add(btnPrintInvoice);


            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
         
            if (int.TryParse(txtUsage.Text, out int usage))
            {
                
                const int subscriptionFee = 50000; 
                const int dayRate = 80;
                const int nightRate = 40; 
                int totalFees = subscriptionFee + (usage * dayRate); 
                txtTotal.Text = totalFees + " VNĐ";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số phút sử dụng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
