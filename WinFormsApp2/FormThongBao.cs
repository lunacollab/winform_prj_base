using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormThongBao : Form
    {
        public FormThongBao()
        {
            InitializeComponent();
            this.Text = "Thông Báo Khách Hàng";
            this.Size = new Size(1195, 546);

            InitializeControls();
        }

        private void InitializeControls()
        {
            ListBox lstNotifications = new ListBox() { Top = 20, Left = 20, Width = 740, Height = 400 };
            lstNotifications.Items.Add("Thông báo: Đình chỉ dịch vụ do chưa thanh toán.");
            lstNotifications.Items.Add("Thông báo: Hồ sơ khách hàng đang trong tình trạng chờ duyệt.");

            Button btnRefresh = new Button() { Text = "Cập Nhật", Top = 450, Left = 20 };
            btnRefresh.Click += (sender, e) => { RefreshNotifications(lstNotifications); };

            Controls.Add(lstNotifications);
            Controls.Add(btnRefresh);
        }

        private void RefreshNotifications(ListBox lstNotifications)
        {
            lstNotifications.Items.Add("Thông báo: Cập nhật mới từ hệ thống.");
            MessageBox.Show("Danh sách thông báo đã được cập nhật.");
        }
    }
}
