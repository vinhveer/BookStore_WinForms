namespace BookStore.Admin
{
    partial class FormAddCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAddress = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            labelDateOfBirth = new Label();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxGender = new ComboBox();
            dateTimePickerDateOfBirth = new DateTimePicker();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            buttonSaveCustomer = new Button();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 290);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(523, 31);
            textBoxAddress.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 262);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 30;
            label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 200);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 29;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 138);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 28;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 76);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 27;
            label6.Text = "Giới tính";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(12, 76);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(91, 25);
            labelDateOfBirth.TabIndex = 26;
            labelDateOfBirth.Text = "Ngày sinh";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(12, 228);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(523, 31);
            textBoxPhoneNumber.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 166);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(523, 31);
            textBoxEmail.TabIndex = 24;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGender.Location = new Point(373, 102);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(162, 33);
            comboBoxGender.TabIndex = 23;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(12, 104);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(355, 31);
            dateTimePickerDateOfBirth.TabIndex = 22;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(373, 14);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(38, 25);
            labelFirstName.TabIndex = 21;
            labelFirstName.Text = "Tên";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(373, 42);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(162, 31);
            textBoxFirstName.TabIndex = 20;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 42);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(355, 31);
            textBoxLastName.TabIndex = 19;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 14);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(36, 25);
            labelLastName.TabIndex = 18;
            labelLastName.Text = "Họ";
            // 
            // buttonSaveCustomer
            // 
            buttonSaveCustomer.Location = new Point(12, 344);
            buttonSaveCustomer.Name = "buttonSaveCustomer";
            buttonSaveCustomer.Size = new Size(184, 34);
            buttonSaveCustomer.TabIndex = 32;
            buttonSaveCustomer.Text = "Lưu thông tin";
            buttonSaveCustomer.UseVisualStyleBackColor = true;
            // 
            // FormAddCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 400);
            Controls.Add(buttonSaveCustomer);
            Controls.Add(textBoxAddress);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelDateOfBirth);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(comboBoxGender);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Name = "FormAddCustomer";
            Text = "Thêm khách hàng mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label labelDateOfBirth;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private Button buttonSaveCustomer;
    }
}