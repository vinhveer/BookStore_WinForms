using BookStore.Data;
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
    public partial class FormAddProduct : Form
    {
        private readonly QlbsContext _context = new QlbsContext();

        public FormAddProduct()
        {
            InitializeComponent();

            LoadCategorys();
            LoadBookAuthors();
            LoadSupplier();
        }

        private void LoadCategorys()
        {
            var categories = _context.Categories.ToList();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
        }

        private void LoadBookAuthors()
        {
            var authors = _context.BookAuthors.ToList();
            comboBoxAuthor.DataSource = authors;
            comboBoxAuthor.DisplayMember = "FullName";
            comboBoxAuthor.ValueMember = "AuthorId";
        }

        private void LoadSupplier()
        {
            var suppliers = _context.Suppliers.ToList();
            comboBoxSupplier.DataSource = suppliers;
            comboBoxSupplier.DisplayMember = "SupplierName";
            comboBoxSupplier.ValueMember = "SupplierId";
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            var bookName = textBoxBookName.Text;
            var categoryId = comboBoxCategory.SelectedValue;
            var authorId = comboBoxAuthor.SelectedValue;
            var supplierId = comboBoxSupplier.SelectedValue;
            var price = numericUpDownPrice.Value;
            var quantity = numericUpDownQuantity.Value;
            var image = textBoxImage.Text;
            var unit = comboBoxUnit.Text;
            var publicationDate = dateTimePickerPublicationDate.Value;

            if (string.IsNullOrWhiteSpace(bookName) || categoryId == null || authorId == null || supplierId == null || price == 0 || quantity == 0 || string.IsNullOrWhiteSpace(image) || string.IsNullOrWhiteSpace(unit))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new QlbsContext())
            {
                var book = new Book
                {
                    BookName = bookName,
                    CategoryId = (long)categoryId,
                    AuthorId = (long)authorId,
                    SupplierId = (long)supplierId,
                    Price = price,
                    BookImage = image,
                    Unit = unit,
                    StockQuantity = (int)quantity,
                    PublicationDate = publicationDate
                };
                db.Books.Add(book);
                db.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string uploadFolder = Path.Combine(Application.StartupPath, "Uploads");
                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }

                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string saveFilePath = Path.Combine(uploadFolder, fileName);

                    File.Copy(openFileDialog.FileName, saveFilePath);

                    textBoxImage.Text = fileName;
                }
            }
        }
    }
}
