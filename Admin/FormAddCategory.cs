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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            var categoryName = textBoxNewCategory.Text;

            if (categoryName == "")
            {
                MessageBox.Show("Please enter category name");
                return;
            }

            using (var db = new QlbsContext())
            {
                var category = new Category
                {
                    CategoryName = categoryName
                };
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
    }
}
