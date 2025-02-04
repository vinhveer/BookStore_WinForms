namespace BookStore.Admin
{
    partial class UserControlAdminHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlAdmin = new TabControl();
            tabPageCustomer = new TabPage();
            textBoxSearchCustomer = new TextBox();
            buttonDeleteCustomer = new Button();
            buttonAddCustomer = new Button();
            dataGridViewCustomer = new DataGridView();
            tabPageEmployee = new TabPage();
            textBoxSearchEmployee = new TextBox();
            buttonDeleteEmployee = new Button();
            buttonAddEmployee = new Button();
            dataGridViewEmployee = new DataGridView();
            tabPageProduct = new TabPage();
            textBoxSearchProduct = new TextBox();
            buttonDeleteProduct = new Button();
            buttonAddProduct = new Button();
            dataGridViewProduct = new DataGridView();
            tabPageCategory = new TabPage();
            textBoxSearchCategory = new TextBox();
            buttonDeleteCategory = new Button();
            buttonAddCategory = new Button();
            dataGridViewCategory = new DataGridView();
            tabControlAdmin.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabPageCustomer);
            tabControlAdmin.Controls.Add(tabPageEmployee);
            tabControlAdmin.Controls.Add(tabPageProduct);
            tabControlAdmin.Controls.Add(tabPageCategory);
            tabControlAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlAdmin.Location = new Point(3, 3);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1372, 605);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(textBoxSearchCustomer);
            tabPageCustomer.Controls.Add(buttonDeleteCustomer);
            tabPageCustomer.Controls.Add(buttonAddCustomer);
            tabPageCustomer.Controls.Add(dataGridViewCustomer);
            tabPageCustomer.Location = new Point(4, 37);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(3);
            tabPageCustomer.Size = new Size(1364, 564);
            tabPageCustomer.TabIndex = 0;
            tabPageCustomer.Text = "Danh sách khách hàng";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Anchor = AnchorStyles.None;
            textBoxSearchCustomer.Location = new Point(670, 9);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchCustomer.Size = new Size(688, 34);
            textBoxSearchCustomer.TabIndex = 3;
            textBoxSearchCustomer.TextChanged += textBoxSearchCustomer_TextChanged;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(254, 6);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(280, 41);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "Xoá khách hàng đã chọn";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(6, 6);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(242, 41);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "Thêm khách hàng mới";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(6, 53);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new Size(1352, 505);
            dataGridViewCustomer.TabIndex = 0;
            dataGridViewCustomer.CellValueChanged += dataGridViewCustomer_CellValueChanged;
            // 
            // tabPageEmployee
            // 
            tabPageEmployee.Controls.Add(textBoxSearchEmployee);
            tabPageEmployee.Controls.Add(buttonDeleteEmployee);
            tabPageEmployee.Controls.Add(buttonAddEmployee);
            tabPageEmployee.Controls.Add(dataGridViewEmployee);
            tabPageEmployee.Location = new Point(4, 37);
            tabPageEmployee.Name = "tabPageEmployee";
            tabPageEmployee.Padding = new Padding(3);
            tabPageEmployee.Size = new Size(1364, 564);
            tabPageEmployee.TabIndex = 1;
            tabPageEmployee.Text = "Danh sách nhân viên";
            tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEmployee
            // 
            textBoxSearchEmployee.Anchor = AnchorStyles.None;
            textBoxSearchEmployee.Location = new Point(671, 6);
            textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            textBoxSearchEmployee.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchEmployee.Size = new Size(687, 34);
            textBoxSearchEmployee.TabIndex = 6;
            textBoxSearchEmployee.TextChanged += textBoxSearchEmployee_TextChanged;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(254, 3);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(280, 41);
            buttonDeleteEmployee.TabIndex = 5;
            buttonDeleteEmployee.Text = "Xoá nhân viên đã chọn";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(6, 3);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(242, 41);
            buttonAddEmployee.TabIndex = 4;
            buttonAddEmployee.Text = "Thêm nhân viên mới";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(6, 50);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowHeadersWidth = 62;
            dataGridViewEmployee.Size = new Size(1355, 508);
            dataGridViewEmployee.TabIndex = 1;
            dataGridViewEmployee.CellValueChanged += dataGridViewEmployee_CellValueChanged;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(textBoxSearchProduct);
            tabPageProduct.Controls.Add(buttonDeleteProduct);
            tabPageProduct.Controls.Add(buttonAddProduct);
            tabPageProduct.Controls.Add(dataGridViewProduct);
            tabPageProduct.Location = new Point(4, 37);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(1364, 564);
            tabPageProduct.TabIndex = 2;
            tabPageProduct.Text = "Danh sách sản phẩm";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Anchor = AnchorStyles.None;
            textBoxSearchProduct.Location = new Point(694, 9);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchProduct.Size = new Size(664, 34);
            textBoxSearchProduct.TabIndex = 9;
            textBoxSearchProduct.TextChanged += textBoxSearchProduct_TextChanged;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(253, 6);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(280, 41);
            buttonDeleteProduct.TabIndex = 8;
            buttonDeleteProduct.Text = "Xoá sản phẩm đã chọn";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(5, 6);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(242, 41);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "Thêm sản phẩm mới";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(6, 53);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 62;
            dataGridViewProduct.Size = new Size(1352, 505);
            dataGridViewProduct.TabIndex = 1;
            dataGridViewProduct.CellValueChanged += dataGridViewProduct_CellValueChanged;
            // 
            // tabPageCategory
            // 
            tabPageCategory.Controls.Add(textBoxSearchCategory);
            tabPageCategory.Controls.Add(buttonDeleteCategory);
            tabPageCategory.Controls.Add(buttonAddCategory);
            tabPageCategory.Controls.Add(dataGridViewCategory);
            tabPageCategory.Location = new Point(4, 37);
            tabPageCategory.Name = "tabPageCategory";
            tabPageCategory.Padding = new Padding(3);
            tabPageCategory.Size = new Size(1364, 564);
            tabPageCategory.TabIndex = 3;
            tabPageCategory.Text = "Danh sách danh mục";
            tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCategory
            // 
            textBoxSearchCategory.Anchor = AnchorStyles.None;
            textBoxSearchCategory.Location = new Point(740, 9);
            textBoxSearchCategory.Name = "textBoxSearchCategory";
            textBoxSearchCategory.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchCategory.Size = new Size(618, 34);
            textBoxSearchCategory.TabIndex = 9;
            textBoxSearchCategory.TextChanged += textBoxSearchCategory_TextChanged;
            // 
            // buttonDeleteCategory
            // 
            buttonDeleteCategory.Location = new Point(254, 6);
            buttonDeleteCategory.Name = "buttonDeleteCategory";
            buttonDeleteCategory.Size = new Size(280, 41);
            buttonDeleteCategory.TabIndex = 8;
            buttonDeleteCategory.Text = "Xoá danh mục đã chọn";
            buttonDeleteCategory.UseVisualStyleBackColor = true;
            buttonDeleteCategory.Click += buttonDeleteCategory_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(6, 6);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(242, 41);
            buttonAddCategory.TabIndex = 7;
            buttonAddCategory.Text = "Thêm danh mục mới";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(6, 53);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersWidth = 62;
            dataGridViewCategory.Size = new Size(1352, 505);
            dataGridViewCategory.TabIndex = 1;
            dataGridViewCategory.CellValueChanged += dataGridViewCategory_CellValueChanged;
            // 
            // UserControlAdminHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAdmin);
            Name = "UserControlAdminHome";
            Size = new Size(1378, 608);
            tabControlAdmin.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            tabPageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            tabPageEmployee.ResumeLayout(false);
            tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            tabPageProduct.ResumeLayout(false);
            tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            tabPageCategory.ResumeLayout(false);
            tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPageCustomer;
        private DataGridView dataGridViewCustomer;
        private TabPage tabPageEmployee;
        private TabPage tabPageProduct;
        private TabPage tabPageCategory;
        private DataGridView dataGridViewEmployee;
        private DataGridView dataGridViewProduct;
        private DataGridView dataGridViewCategory;
        private Button buttonAddCustomer;
        private Button buttonDeleteCustomer;
        private TextBox textBoxSearchCustomer;
        private TextBox textBoxSearchEmployee;
        private Button buttonDeleteEmployee;
        private Button buttonAddEmployee;
        private TextBox textBoxSearchProduct;
        private Button buttonDeleteProduct;
        private Button buttonAddProduct;
        private TextBox textBoxSearchCategory;
        private Button buttonDeleteCategory;
        private Button buttonAddCategory;
    }
}
