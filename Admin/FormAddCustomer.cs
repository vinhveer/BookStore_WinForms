using BookStore.Data;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Admin
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            var lastName = textBoxLastName.Text;
            var firstName = textBoxFirstName.Text;
            var dob = dateTimePickerDateOfBirth.Value;
            var gender = comboBoxGender.Text == "Nam" ? "M" : "F";
            var email = textBoxEmail.Text;
            var phone = textBoxPhoneNumber.Text;
            var address = textBoxAddress.Text;

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

            using (var db = new QlbsContext())
            {
                var customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dob,
                    Gender = gender,
                    CustomerEmail = email,
                    CustomerPhone = phone,
                    CustomerAddress = address
                };

                db.Customers.Add(customer);
                db.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
