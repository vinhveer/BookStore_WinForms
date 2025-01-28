namespace BookStore.Admin
{
    partial class UserControlAddCustomer
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
            labelTitleAddCustomer = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelTitleAddCustomer
            // 
            labelTitleAddCustomer.AutoSize = true;
            labelTitleAddCustomer.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitleAddCustomer.Location = new Point(25, 39);
            labelTitleAddCustomer.Name = "labelTitleAddCustomer";
            labelTitleAddCustomer.Size = new Size(284, 38);
            labelTitleAddCustomer.TabIndex = 0;
            labelTitleAddCustomer.Text = "Thêm khách hàng mới";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(1007, 488);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 1;
            button1.Text = "Huỷ bỏ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(835, 488);
            button2.Name = "button2";
            button2.Size = new Size(166, 43);
            button2.TabIndex = 2;
            button2.Text = "Lưu thông tin";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControlAddCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTitleAddCustomer);
            Name = "UserControlAddCustomer";
            Size = new Size(1178, 557);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleAddCustomer;
        private Button button1;
        private Button button2;
    }
}
