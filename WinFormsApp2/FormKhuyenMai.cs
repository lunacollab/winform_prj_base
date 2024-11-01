using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormKhuyenMai : Form
    {
        public FormKhuyenMai()
        {
            InitializeComponent();
            this.Text = "Quản Lý Khuyến Mãi";
            this.Size = new Size(1195, 546);

            InitializeControls();
        }

        private void InitializeControls()
        {
            Label lblPromotionName = new Label() { Text = "Tên Khuyến Mãi", Top = 20, Left = 20 };
            TextBox txtPromotionName = new TextBox() { Top = 20, Left = 150, Width = 200 };

            Label lblStartDate = new Label() { Text = "Ngày Bắt Đầu", Top = 60, Left = 20 };
            DateTimePicker dtpStartDate = new DateTimePicker() { Top = 60, Left = 150 };

            Label lblEndDate = new Label() { Text = "Ngày Kết Thúc", Top = 100, Left = 20 };
            DateTimePicker dtpEndDate = new DateTimePicker() { Top = 100, Left = 150 };

            Label lblDetails = new Label() { Text = "Chi Tiết Ưu Đãi", Top = 140, Left = 20 };
            TextBox txtDetails = new TextBox() { Top = 140, Left = 150, Width = 200, Height = 100, Multiline = true };

            Button btnAdd = new Button() { Text = "Thêm Khuyến Mãi", Top = 260, Left = 150 };
            btnAdd.Click += (sender, e) => { AddPromotion(txtPromotionName.Text, dtpStartDate.Value, dtpEndDate.Value, txtDetails.Text); };

            Controls.Add(lblPromotionName);
            Controls.Add(txtPromotionName);
            Controls.Add(lblStartDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpEndDate);
            Controls.Add(lblDetails);
            Controls.Add(txtDetails);
            Controls.Add(btnAdd);
        }

        private void AddPromotion(string promotionName, DateTime startDate, DateTime endDate, string details)
        {
            MessageBox.Show($"Thêm khuyến mãi '{promotionName}' từ {startDate.ToShortDateString()} đến {endDate.ToShortDateString()}.");
        }
    }
}
