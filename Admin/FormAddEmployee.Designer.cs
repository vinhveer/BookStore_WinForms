namespace BookStore.Admin
{
    partial class FormAddEmployee
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
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            comboBoxGender = new ComboBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            comboBoxRoleName = new ComboBox();
            dateTimePickerHireDate = new DateTimePicker();
            labelDateOfBirth = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxAddress = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxUsername = new TextBox();
            label12 = new Label();
            textBoxPassword = new TextBox();
            label13 = new Label();
            buttonSaveEmployee = new Button();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 49);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(36, 25);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Họ";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 77);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(355, 31);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(373, 77);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(162, 31);
            textBoxFirstName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(373, 49);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(38, 25);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(197, 28);
            label3.TabIndex = 4;
            label3.Text = "Thông tin nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(573, 9);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 5;
            label4.Text = "Thông tin tài khoản";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new Point(12, 139);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(355, 31);
            dateTimePickerDateOfBirth.TabIndex = 6;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGender.Location = new Point(373, 137);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(162, 33);
            comboBoxGender.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 201);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(523, 31);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(12, 263);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(523, 31);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // comboBoxRoleName
            // 
            comboBoxRoleName.FormattingEnabled = true;
            comboBoxRoleName.Items.AddRange(new object[] { "Admin", "Staff" });
            comboBoxRoleName.Location = new Point(373, 389);
            comboBoxRoleName.Name = "comboBoxRoleName";
            comboBoxRoleName.Size = new Size(162, 33);
            comboBoxRoleName.TabIndex = 11;
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Location = new Point(12, 387);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(355, 31);
            dateTimePickerHireDate.TabIndex = 10;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(12, 111);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(91, 25);
            labelDateOfBirth.TabIndex = 12;
            labelDateOfBirth.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 111);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 13;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 173);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 235);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 15;
            label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 297);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 16;
            label9.Text = "Địa chỉ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 325);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(523, 31);
            textBoxAddress.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 359);
            label10.Name = "label10";
            label10.Size = new Size(122, 25);
            label10.TabIndex = 18;
            label10.Text = "Ngày vào làm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(373, 359);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 19;
            label11.Text = "Vai trò";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(573, 77);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(355, 31);
            textBoxUsername.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(573, 49);
            label12.Name = "label12";
            label12.Size = new Size(129, 25);
            label12.TabIndex = 20;
            label12.Text = "Tên đăng nhập";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(573, 141);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(355, 31);
            textBoxPassword.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(573, 113);
            label13.Name = "label13";
            label13.Size = new Size(86, 25);
            label13.TabIndex = 22;
            label13.Text = "Mật khẩu";
            // 
            // buttonSaveEmployee
            // 
            buttonSaveEmployee.Location = new Point(744, 389);
            buttonSaveEmployee.Name = "buttonSaveEmployee";
            buttonSaveEmployee.Size = new Size(184, 34);
            buttonSaveEmployee.TabIndex = 24;
            buttonSaveEmployee.Text = "Lưu thông tin";
            buttonSaveEmployee.UseVisualStyleBackColor = true;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(buttonSaveEmployee);
            Controls.Add(textBoxPassword);
            Controls.Add(label13);
            Controls.Add(textBoxUsername);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxAddress);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelDateOfBirth);
            Controls.Add(comboBoxRoleName);
            Controls.Add(dateTimePickerHireDate);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(comboBoxGender);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Name = "FormAddEmployee";
            Text = "Thêm nhân viên mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLastName;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerDateOfBirth;
        private ComboBox comboBoxGender;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxRoleName;
        private DateTimePicker dateTimePickerHireDate;
        private Label labelDateOfBirth;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxAddress;
        private Label label10;
        private Label label11;
        private TextBox textBoxUsername;
        private Label label12;
        private TextBox textBoxPassword;
        private Label label13;
        private Button buttonSaveEmployee;
    }
}