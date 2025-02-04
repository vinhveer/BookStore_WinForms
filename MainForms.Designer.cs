namespace BookStore
{
    partial class MainForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            thôngTinĐăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinĐăngNhậpToolStripMenuItem, đăngXuấToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1378, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinĐăngNhậpToolStripMenuItem
            // 
            thôngTinĐăngNhậpToolStripMenuItem.Name = "thôngTinĐăngNhậpToolStripMenuItem";
            thôngTinĐăngNhậpToolStripMenuItem.Size = new Size(211, 32);
            thôngTinĐăngNhậpToolStripMenuItem.Text = "Thông tin đăng nhập";
            // 
            // đăngXuấToolStripMenuItem
            // 
            đăngXuấToolStripMenuItem.Name = "đăngXuấToolStripMenuItem";
            đăngXuấToolStripMenuItem.Size = new Size(117, 32);
            đăngXuấToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panelMain
            // 
            panelMain.Font = new Font("Segoe UI", 10F);
            panelMain.Location = new Point(0, 39);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1378, 608);
            panelMain.TabIndex = 1;
            // 
            // MainForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 644);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForms";
            Text = "Hệ thống quản lý nhà sách";
            FormClosed += MainForms_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panelMain;
        private ToolStripMenuItem thôngTinĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấToolStripMenuItem;
    }
}
