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
            tabPageEmployee = new TabPage();
            tabPageProduct = new TabPage();
            tabPageCategory = new TabPage();
            dataGridViewCustomer = new DataGridView();
            this.dataGridViewEmployee = new DataGridView();
            this.dataGridViewProduct = new DataGridView();
            this.dataGridViewCategory = new DataGridView();
            buttonAddCustomer = new Button();
            buttonDeleteCustomer = new Button();
            textBoxSearchCustomer = new TextBox();
            textBoxSearchEmployee = new TextBox();
            buttonDeleteEmployee = new Button();
            buttonAddEmployee = new Button();
            textBoxSearchProduct = new TextBox();
            buttonDeleteProduct = new Button();
            buttonAddProduct = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tabControlAdmin.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            tabPageEmployee.SuspendLayout();
            tabPageProduct.SuspendLayout();
            tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewCategory).BeginInit();
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
            tabControlAdmin.Size = new Size(1172, 551);
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
            tabPageCustomer.Size = new Size(1164, 510);
            tabPageCustomer.TabIndex = 0;
            tabPageCustomer.Text = "Danh sách khách hàng";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployee
            // 
            tabPageEmployee.Controls.Add(textBoxSearchEmployee);
            tabPageEmployee.Controls.Add(buttonDeleteEmployee);
            tabPageEmployee.Controls.Add(buttonAddEmployee);
            tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            tabPageEmployee.Location = new Point(4, 37);
            tabPageEmployee.Name = "tabPageEmployee";
            tabPageEmployee.Padding = new Padding(3);
            tabPageEmployee.Size = new Size(1164, 510);
            tabPageEmployee.TabIndex = 1;
            tabPageEmployee.Text = "Danh sách nhân viên";
            tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(textBoxSearchProduct);
            tabPageProduct.Controls.Add(buttonDeleteProduct);
            tabPageProduct.Controls.Add(buttonAddProduct);
            tabPageProduct.Controls.Add(this.dataGridViewProduct);
            tabPageProduct.Location = new Point(4, 37);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(1164, 510);
            tabPageProduct.TabIndex = 2;
            tabPageProduct.Text = "Danh sách sản phẩm";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            tabPageCategory.Controls.Add(textBox1);
            tabPageCategory.Controls.Add(button1);
            tabPageCategory.Controls.Add(button2);
            tabPageCategory.Controls.Add(this.dataGridViewCategory);
            tabPageCategory.Location = new Point(4, 37);
            tabPageCategory.Name = "tabPageCategory";
            tabPageCategory.Padding = new Padding(3);
            tabPageCategory.Size = new Size(1164, 510);
            tabPageCategory.TabIndex = 3;
            tabPageCategory.Text = "Danh sách danh mục";
            tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(6, 53);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new Size(1152, 454);
            dataGridViewCustomer.TabIndex = 0;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new Point(6, 50);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.Size = new Size(1152, 457);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new Point(6, 53);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 62;
            this.dataGridViewProduct.Size = new Size(1152, 454);
            this.dataGridViewProduct.TabIndex = 1;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new Point(6, 53);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 62;
            this.dataGridViewCategory.Size = new Size(1152, 454);
            this.dataGridViewCategory.TabIndex = 1;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(6, 6);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(242, 41);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "Thêm khách hàng mới";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(254, 6);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(280, 41);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "Xoá khách hàng đã chọn";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Anchor = AnchorStyles.None;
            textBoxSearchCustomer.Location = new Point(540, 9);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchCustomer.Size = new Size(618, 34);
            textBoxSearchCustomer.TabIndex = 3;
            textBoxSearchCustomer.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSearchEmployee
            // 
            textBoxSearchEmployee.Anchor = AnchorStyles.None;
            textBoxSearchEmployee.Location = new Point(540, 6);
            textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            textBoxSearchEmployee.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchEmployee.Size = new Size(618, 34);
            textBoxSearchEmployee.TabIndex = 6;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Location = new Point(254, 3);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(280, 41);
            buttonDeleteEmployee.TabIndex = 5;
            buttonDeleteEmployee.Text = "Xoá nhân viên đã chọn";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(6, 3);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(242, 41);
            buttonAddEmployee.TabIndex = 4;
            buttonAddEmployee.Text = "Thêm nhân viên mới";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Anchor = AnchorStyles.None;
            textBoxSearchProduct.Location = new Point(539, 9);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchProduct.Size = new Size(618, 34);
            textBoxSearchProduct.TabIndex = 9;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(253, 6);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(280, 41);
            buttonDeleteProduct.TabIndex = 8;
            buttonDeleteProduct.Text = "Xoá sản phẩm đã chọn";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(5, 6);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(242, 41);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "Thêm sản phẩm mới";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(540, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBox1.Size = new Size(618, 34);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(254, 6);
            button1.Name = "button1";
            button1.Size = new Size(280, 41);
            button1.TabIndex = 8;
            button1.Text = "Xoá danh mục đã chọn";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(242, 41);
            button2.TabIndex = 7;
            button2.Text = "Thêm danh mục mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControlAdminHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAdmin);
            Name = "UserControlAdminHome";
            Size = new Size(1178, 557);
            tabControlAdmin.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            tabPageCustomer.PerformLayout();
            tabPageEmployee.ResumeLayout(false);
            tabPageEmployee.PerformLayout();
            tabPageProduct.ResumeLayout(false);
            tabPageProduct.PerformLayout();
            tabPageCategory.ResumeLayout(false);
            tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewCategory).EndInit();
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
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
