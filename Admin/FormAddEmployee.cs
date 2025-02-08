using BookStore.Data;
using Microsoft.IdentityModel.Tokens;
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

namespace BookStore.Admin
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            var lastName = textBoxLastName.Text;
            var firstName = textBoxFirstName.Text;
            var dob = dateTimePickerDateOfBirth.Value;
            var gender = comboBoxGender.Text == "Nam" ? "M" : "F";
            var email = textBoxEmail.Text;
            var phone = textBoxPhoneNumber.Text;
            var address = textBoxAddress.Text;
            var hireDate = dateTimePickerHireDate.Value;
            var roleName = comboBoxRoleName.Text;

            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gender.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hireDate > DateTime.Now)
            {
                MessageBox.Show("Ngày tuyển dụng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (roleName.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userName = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            var hashPassword = HashPassword(password);

            using (var db = new QlbsContext())
            {
                var employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dob,
                    Gender = gender,
                    EmployeeEmail = email,
                    EmployeePhone = phone,
                    EmployeeAddress = address,
                    HireDate = hireDate,
                    RoleName = roleName
                };

                var employeeAccount = new Employeeaccount
                {
                    EmployeeUsername = userName,
                    EmployeePassword = hashPassword
                };

                employee.Employeeaccount = employeeAccount;
                db.Employees.Add(employee);
                db.SaveChanges();

                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
