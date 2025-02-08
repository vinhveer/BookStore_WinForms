namespace BookStore.Admin
{
    partial class FormAddCategory
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
            textBoxNewCategory = new TextBox();
            label12 = new Label();
            buttonSaveCategory = new Button();
            SuspendLayout();
            // 
            // textBoxNewCategory
            // 
            textBoxNewCategory.Location = new Point(12, 44);
            textBoxNewCategory.Name = "textBoxNewCategory";
            textBoxNewCategory.Size = new Size(776, 31);
            textBoxNewCategory.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 16);
            label12.Name = "label12";
            label12.Size = new Size(158, 25);
            label12.TabIndex = 22;
            label12.Text = "Tên danh mục mới";
            // 
            // buttonSaveCategory
            // 
            buttonSaveCategory.Location = new Point(539, 81);
            buttonSaveCategory.Name = "buttonSaveCategory";
            buttonSaveCategory.Size = new Size(249, 34);
            buttonSaveCategory.TabIndex = 24;
            buttonSaveCategory.Text = "Thêm danh mục mới";
            buttonSaveCategory.UseVisualStyleBackColor = true;
            buttonSaveCategory.Click += buttonSaveCategory_Click;
            // 
            // FormAddCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 123);
            Controls.Add(buttonSaveCategory);
            Controls.Add(textBoxNewCategory);
            Controls.Add(label12);
            Name = "FormAddCategory";
            Text = "Thêm danh mục mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewCategory;
        private Label label12;
        private Button buttonSaveCategory;
    }
}