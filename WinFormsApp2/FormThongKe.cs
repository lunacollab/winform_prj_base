using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormThongKe : Form
    {
        private DataGridView dataGridViewCustomers;
        private Button btnLoadStatistics;
        private Label lblTitle;

        public FormThongKe()
        {
            InitializeComponent();
            this.Text = "Thống Kê Khách Hàng";
            this.Size = new System.Drawing.Size(1195, 546);

            lblTitle = new Label()
            {
                Text = "Danh Sách Khách Hàng và Tình Trạng Thanh Toán",
                Left = 20,
                Top = 20,
                Width = 400,
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold)
            };

            dataGridViewCustomers = new DataGridView()
            {
                Left = 20,
                Top = 60,
                Width = 740,
                Height = 400,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true
            };
            dataGridViewCustomers.Columns.Add("CustomerName", "Tên Khách Hàng");
            dataGridViewCustomers.Columns.Add("CMND", "Số CMND");
            dataGridViewCustomers.Columns.Add("Status", "Trạng Thái Thanh Toán");

            btnLoadStatistics = new Button()
            {
                Text = "Tải Thống Kê",
                Left = 20,
                Top = 480,
                Width = 150,
                Height = 40
            };
            btnLoadStatistics.Click += BtnLoadStatistics_Click;

            Controls.Add(lblTitle);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(btnLoadStatistics);
        }

        private void BtnLoadStatistics_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            List<Customer> customers = GetSampleData();
            dataGridViewCustomers.Rows.Clear();

            foreach (var customer in customers)
            {
                dataGridViewCustomers.Rows.Add(customer.Name, customer.CMND, customer.PaymentStatus);
            }
        }

        private List<Customer> GetSampleData()
        {
            return new List<Customer>
            {
                new Customer { Name = "Nguyễn Văn A", CMND = "123456789", PaymentStatus = "Đã thanh toán" },
                new Customer { Name = "Trần Thị B", CMND = "987654321", PaymentStatus = "Chưa thanh toán" },
                new Customer { Name = "Lê Văn C", CMND = "456789123", PaymentStatus = "Đã thanh toán" }
            };
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string CMND { get; set; }
        public string PaymentStatus { get; set; }
    }
}
