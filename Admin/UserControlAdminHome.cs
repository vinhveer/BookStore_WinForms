using BookStore.Data;
using BookStore.DTO;
using Microsoft.VisualBasic.Devices;
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
    public partial class UserControlAdminHome : UserControl
    {
        private readonly QlbsContext _context = new QlbsContext();

        public UserControlAdminHome()
        {
            InitializeComponent();

            LoadCustomers();
            LoadEmployees();
            LoadProducts();
            LoadCategorys();
        }

        private void LoadCustomers()
        {
            var customers = _context.Customers.Select(c => new CustomerDTO
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                DateOfBirth = c.DateOfBirth,
                Gender = c.Gender,
                CustomerEmail = c.CustomerEmail,
                CustomerPhone = c.CustomerPhone,
                CustomerAddress = c.CustomerAddress
            }).ToList();

            dataGridViewCustomer.DataSource = customers;
        }

        private void LoadEmployees()
        {
            var employees = _context.Employees.Select(e => new EmployeeDTO
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DateOfBirth = e.DateOfBirth,
                Gender = e.Gender,
                EmployeeEmail = e.EmployeeEmail,
                EmployeePhone = e.EmployeePhone,
                EmployeeAddress = e.EmployeeAddress,
                RoleName = e.RoleName,
                HireDate = e.HireDate
            }).ToList();

            dataGridViewEmployee.DataSource = employees;
        }

        private void LoadProducts()
        {
            var products = _context.Books.Select(b => new ProductDTO
            {
                BookId = b.BookId,
                BookName = b.BookName,
                Unit = b.Unit,
                StockQuantity = b.StockQuantity,
                Price = b.Price,
                PublicationDate = b.PublicationDate,
                BookImage = b.BookImage,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                SupplierName = b.Supplier.SupplierName,
                CategoryName = b.Category.CategoryName
            }).ToList();

            dataGridViewProduct.DataSource = products;
        }

        private void LoadCategorys()
        {
            var categorys = _context.Categories.Select(c => new CategoryDTO
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName
            }).ToList();

            dataGridViewCategory.DataSource = categorys;
        }

        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBoxSearchCustomer.Text;

            var customers = _context.Customers.Select(c => new CustomerDTO
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                DateOfBirth = c.DateOfBirth,
                Gender = c.Gender,
                CustomerEmail = c.CustomerEmail,
                CustomerPhone = c.CustomerPhone,
                CustomerAddress = c.CustomerAddress
            }).Where(c => c.FirstName.Contains(keyword) || c.LastName.Contains(keyword)).ToList();

            dataGridViewCustomer.DataSource = customers;
        }

        private void textBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBoxSearchEmployee.Text;

            var employees = _context.Employees.Select(e => new EmployeeDTO
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DateOfBirth = e.DateOfBirth,
                Gender = e.Gender,
                EmployeeEmail = e.EmployeeEmail,
                EmployeePhone = e.EmployeePhone,
                EmployeeAddress = e.EmployeeAddress,
                RoleName = e.RoleName,
                HireDate = e.HireDate
            }).Where(e => e.FirstName.Contains(keyword) || e.LastName.Contains(keyword)).ToList();

            dataGridViewEmployee.DataSource = employees;
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBoxSearchProduct.Text;

            var products = _context.Books.Select(b => new ProductDTO
            {
                BookId = b.BookId,
                BookName = b.BookName,
                Unit = b.Unit,
                StockQuantity = b.StockQuantity,
                Price = b.Price,
                PublicationDate = b.PublicationDate,
                BookImage = b.BookImage,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                SupplierName = b.Supplier.SupplierName,
                CategoryName = b.Category.CategoryName
            }).Where(p => p.BookName.Contains(keyword)).ToList();

            dataGridViewProduct.DataSource = products;
        }

        private void textBoxSearchCategory_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBoxSearchCategory.Text;

            var categorys = _context.Categories.Select(c => new CategoryDTO
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName
            }).Where(c => c.CategoryName.Contains(keyword)).ToList();

            dataGridViewCategory.DataSource = categorys;
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewCustomer.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRows.Count == 1)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var customerId = Convert.ToInt64(selectedRows[0].Cells[0].Value);
                    var customer = _context.Customers.Find(customerId);
                    if (customer != null)
                    {
                        _context.Customers.Remove(customer);
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa những khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var customerId = Convert.ToInt64(row.Cells[0].Value);
                        var customer = _context.Customers.Find(customerId);
                        if (customer != null)
                        {
                            _context.Customers.Remove(customer);
                        }
                    }
                    _context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewEmployee.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRows.Count == 1)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var employeeId = Convert.ToInt64(selectedRows[0].Cells[0].Value);
                    var employee = _context.Employees.Find(employeeId);
                    if (employee != null)
                    {
                        _context.Employees.Remove(employee);
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa những nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var employeeId = Convert.ToInt64(row.Cells[0].Value);
                        var employee = _context.Employees.Find(employeeId);
                        if (employee != null)
                        {
                            _context.Employees.Remove(employee);
                        }
                    }
                    _context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewProduct.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRows.Count == 1)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bookId = Convert.ToInt64(selectedRows[0].Cells[0].Value);
                    var book = _context.Books.Find(bookId);
                    if (book != null)
                    {
                        _context.Books.Remove(book);
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa những sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var bookId = Convert.ToInt64(row.Cells[0].Value);
                        var book = _context.Books.Find(bookId);
                        if (book != null)
                        {
                            _context.Books.Remove(book);
                        }
                    }
                    _context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewProduct.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRows.Count == 1)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var categoryId = Convert.ToInt64(selectedRows[0].Cells[0].Value);
                    var category = _context.Categories.Find(categoryId);
                    if (category != null)
                    {
                        _context.Categories.Remove(category);
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Danh mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa những danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var categoryId = Convert.ToInt64(row.Cells[0].Value);
                        var category = _context.Categories.Find(categoryId);
                        if (category != null)
                        {
                            _context.Categories.Remove(category);
                        }
                    }
                    _context.SaveChanges();
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Danh mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewCustomer.Rows[e.RowIndex];
                if (row.DataBoundItem is CustomerDTO customer)
                {
                    try
                    {
                        var exitingCustomer = _context.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);

                        if (exitingCustomer == null)
                        {
                            MessageBox.Show("Khách hàng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        exitingCustomer.FirstName = customer.FirstName;
                        exitingCustomer.LastName = customer.LastName;
                        exitingCustomer.DateOfBirth = customer.DateOfBirth;
                        exitingCustomer.Gender = customer.Gender;
                        exitingCustomer.CustomerEmail = customer.CustomerEmail;
                        exitingCustomer.CustomerPhone = customer.CustomerPhone;
                        exitingCustomer.CustomerAddress = customer.CustomerAddress;

                        _context.SaveChanges();

                        MessageBox.Show("Cập nhật thành công");

                        LoadCustomers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewEmployee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewEmployee.Rows[e.RowIndex];
                if (row.DataBoundItem is EmployeeDTO employee)
                {
                    try
                    {
                        var existingEmployee = _context.Employees.FirstOrDefault(c => c.EmployeeId == employee.EmployeeId);

                        if (existingEmployee == null)
                        {
                            MessageBox.Show("Nhân viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        existingEmployee.FirstName = employee.FirstName;
                        existingEmployee.LastName = employee.LastName;
                        existingEmployee.DateOfBirth = employee.DateOfBirth;
                        existingEmployee.Gender = employee.Gender;
                        existingEmployee.EmployeeEmail = employee.EmployeeEmail;
                        existingEmployee.EmployeePhone = employee.EmployeePhone;
                        existingEmployee.EmployeeAddress = employee.EmployeeAddress;
                        existingEmployee.RoleName = employee.RoleName;
                        existingEmployee.HireDate = employee.HireDate;

                        _context.SaveChanges();

                        MessageBox.Show("Cập nhật thành công");

                        LoadCustomers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewEmployee.Rows[e.RowIndex];
                if (row.DataBoundItem is ProductDTO product)
                {
                    try
                    {
                        var existingProduct = _context.Books.FirstOrDefault(c => c.BookId == product.BookId);

                        if (existingProduct == null)
                        {
                            MessageBox.Show("Sản phẩm không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        existingProduct.BookName = product.BookName;
                        existingProduct.Unit = product.Unit;
                        existingProduct.StockQuantity = product.StockQuantity;
                        existingProduct.Price = product.Price;
                        existingProduct.PublicationDate = product.PublicationDate;

                        _context.SaveChanges();

                        MessageBox.Show("Cập nhật thành công");

                        LoadCustomers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewEmployee.Rows[e.RowIndex];
                if (row.DataBoundItem is CategoryDTO category)
                {
                    try
                    {
                        var existingCategory = _context.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

                        if (existingCategory == null)
                        {
                            MessageBox.Show("Danh mục không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        existingCategory.CategoryName = category.CategoryName;

                        _context.SaveChanges();

                        MessageBox.Show("Cập nhật thành công");

                        LoadCustomers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer formAddCustomer = new FormAddCustomer();
            formAddCustomer.ShowDialog();

            LoadCustomers();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.ShowDialog();

            LoadEmployees();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.ShowDialog();

            LoadProducts();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.ShowDialog();

            LoadCategorys();
        }
    }
}
