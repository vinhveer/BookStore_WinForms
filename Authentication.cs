using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Authentication : Form
    {
        private readonly QlbsContext _context = new QlbsContext();
        private bool _isAuthenticated = false;
        private Employee? _employee;

        public bool IsAuthenticated => _isAuthenticated;
        public Employee? Employee => _employee;

        public Authentication()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelAlert.Text = "Đang thực hiện truy vấn ...";

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string hashedPassword = HashPassword(password);

            var user = _context.Employeeaccounts.FirstOrDefault(u => u.EmployeeUsername == username && u.EmployeePassword == hashedPassword);

            if (user == null)
            {
                labelAlert.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            }
            else
            {
                var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == user.EmployeeId);

                if (employee == null)
                {
                    labelAlert.Text = "Không có thông tin người dùng";
                }
                else
                {
                    _isAuthenticated = true;
                    _employee = employee;

                    Hide();
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        private void Authentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isAuthenticated)
            {
                Application.Exit();
            }
        }
    }
}
