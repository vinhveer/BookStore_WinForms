namespace BookStore.Staff
{
    partial class UserControlStaffHome
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
            tabControlStaff = new TabControl();
            tabPageSell = new TabPage();
            tabPageInvoice = new TabPage();
            dataGridViewListProduct = new DataGridView();
            textBoxSearchProduct = new TextBox();
            labelListProduct = new Label();
            dataGridViewBuyProduct = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            buttonPayment = new Button();
            buttonPayPoint = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewInvoice = new DataGridView();
            textBoxSearchInvoice = new TextBox();
            tabControlStaff.SuspendLayout();
            tabPageSell.SuspendLayout();
            tabPageInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuyProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            SuspendLayout();
            // 
            // tabControlStaff
            // 
            tabControlStaff.Controls.Add(tabPageSell);
            tabControlStaff.Controls.Add(tabPageInvoice);
            tabControlStaff.Location = new Point(3, 3);
            tabControlStaff.Name = "tabControlStaff";
            tabControlStaff.SelectedIndex = 0;
            tabControlStaff.Size = new Size(1172, 551);
            tabControlStaff.TabIndex = 0;
            // 
            // tabPageSell
            // 
            tabPageSell.Controls.Add(comboBox1);
            tabPageSell.Controls.Add(label3);
            tabPageSell.Controls.Add(buttonPayPoint);
            tabPageSell.Controls.Add(buttonPayment);
            tabPageSell.Controls.Add(label2);
            tabPageSell.Controls.Add(label1);
            tabPageSell.Controls.Add(dataGridViewBuyProduct);
            tabPageSell.Controls.Add(labelListProduct);
            tabPageSell.Controls.Add(textBoxSearchProduct);
            tabPageSell.Controls.Add(dataGridViewListProduct);
            tabPageSell.Location = new Point(4, 37);
            tabPageSell.Name = "tabPageSell";
            tabPageSell.Padding = new Padding(3);
            tabPageSell.Size = new Size(1164, 510);
            tabPageSell.TabIndex = 0;
            tabPageSell.Text = "Bán hàng";
            tabPageSell.UseVisualStyleBackColor = true;
            // 
            // tabPageInvoice
            // 
            tabPageInvoice.Controls.Add(textBoxSearchInvoice);
            tabPageInvoice.Controls.Add(dataGridViewInvoice);
            tabPageInvoice.Location = new Point(4, 37);
            tabPageInvoice.Name = "tabPageInvoice";
            tabPageInvoice.Padding = new Padding(3);
            tabPageInvoice.Size = new Size(1164, 510);
            tabPageInvoice.TabIndex = 1;
            tabPageInvoice.Text = "Danh sách hoá đơn";
            tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListProduct
            // 
            dataGridViewListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListProduct.Location = new Point(472, 50);
            dataGridViewListProduct.Name = "dataGridViewListProduct";
            dataGridViewListProduct.RowHeadersWidth = 62;
            dataGridViewListProduct.Size = new Size(686, 454);
            dataGridViewListProduct.TabIndex = 0;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Location = new Point(472, 9);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchProduct.Size = new Size(686, 34);
            textBoxSearchProduct.TabIndex = 1;
            // 
            // labelListProduct
            // 
            labelListProduct.AutoSize = true;
            labelListProduct.Location = new Point(7, 12);
            labelListProduct.Name = "labelListProduct";
            labelListProduct.Size = new Size(190, 28);
            labelListProduct.TabIndex = 3;
            labelListProduct.Text = "Danh sách sản phẩm";
            // 
            // dataGridViewBuyProduct
            // 
            dataGridViewBuyProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuyProduct.Location = new Point(7, 50);
            dataGridViewBuyProduct.Name = "dataGridViewBuyProduct";
            dataGridViewBuyProduct.RowHeadersWidth = 62;
            dataGridViewBuyProduct.Size = new Size(459, 314);
            dataGridViewBuyProduct.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 420);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 5;
            label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(274, 420);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 6;
            label2.Text = "Tổng tiền";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonPayment
            // 
            buttonPayment.Location = new Point(7, 463);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(144, 41);
            buttonPayment.TabIndex = 7;
            buttonPayment.Text = "Thanh toán";
            buttonPayment.UseVisualStyleBackColor = true;
            // 
            // buttonPayPoint
            // 
            buttonPayPoint.Location = new Point(157, 463);
            buttonPayPoint.Name = "buttonPayPoint";
            buttonPayPoint.Size = new Size(309, 41);
            buttonPayPoint.TabIndex = 8;
            buttonPayPoint.Text = "Thanh toán tích điểm";
            buttonPayPoint.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 381);
            label3.Name = "label3";
            label3.Size = new Size(105, 32);
            label3.TabIndex = 9;
            label3.Text = "Giảm giá";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 381);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 36);
            comboBox1.TabIndex = 10;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(6, 50);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 62;
            dataGridViewInvoice.Size = new Size(1152, 454);
            dataGridViewInvoice.TabIndex = 0;
            // 
            // textBoxSearchInvoice
            // 
            textBoxSearchInvoice.Location = new Point(6, 8);
            textBoxSearchInvoice.Name = "textBoxSearchInvoice";
            textBoxSearchInvoice.PlaceholderText = "Tìm kiếm hoá đơn";
            textBoxSearchInvoice.Size = new Size(1152, 34);
            textBoxSearchInvoice.TabIndex = 3;
            // 
            // UserControlStaffHome
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlStaff);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlStaffHome";
            Size = new Size(1178, 557);
            tabControlStaff.ResumeLayout(false);
            tabPageSell.ResumeLayout(false);
            tabPageSell.PerformLayout();
            tabPageInvoice.ResumeLayout(false);
            tabPageInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuyProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlStaff;
        private TabPage tabPageSell;
        private TabPage tabPageInvoice;
        private DataGridView dataGridViewBuyProduct;
        private Label labelListProduct;
        private TextBox textBoxSearchProduct;
        private DataGridView dataGridViewListProduct;
        private Label label2;
        private Label label1;
        private Button buttonPayPoint;
        private Button buttonPayment;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBoxSearchInvoice;
        private DataGridView dataGridViewInvoice;
    }
}
