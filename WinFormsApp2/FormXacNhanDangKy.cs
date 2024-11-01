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
    public partial class FormXacNhanDangKy : Form
    {
        private Label lblInfo;
        private Label lblStatus;
        private Button btnApprove;
        private Button btnWaitlist;

        public FormXacNhanDangKy()
        {
            this.Text = "Form Xác Nhận Đăng Ký";
            this.Size = new System.Drawing.Size(1195, 546);

            lblInfo = new Label() { Text = "Thông tin đã đăng ký", Left = 20, Top = 20, Width = 1150 };
            lblStatus = new Label() { Text = "Tình trạng khách hàng", Left = 20, Top = 60, Width = 1150 };
            btnApprove = new Button() { Text = "Xác nhận", Left = 20, Top = 100, Width = 150, Height = 40 };
            btnWaitlist = new Button() { Text = "Danh sách đợi", Left = 200, Top = 100, Width = 150, Height = 40 };

            Controls.Add(lblInfo);
            Controls.Add(lblStatus);
            Controls.Add(btnApprove);
            Controls.Add(btnWaitlist);
            InitializeComponent();
        }
    }

}



