using BookStore.Admin;
using BookStore.Staff;

namespace BookStore
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();

            ShowLoginDialog();
        }

        private void ShowLoginDialog()
        {
            var loginForm = new Authentication();
            loginForm.ShowDialog();

            if (loginForm.IsAuthenticated)
            {
                string role = loginForm.Employee?.RoleName ?? "Không xác định";

                if (role == "Admin")
                {
                    UserControlAdminHome userControlAdminHome = new UserControlAdminHome();
                    panelMain.Controls.Add(userControlAdminHome);
                }
                else if (role == "Staff")
                {
                    UserControlStaffHome userControlStaffHome = new UserControlStaffHome();
                    panelMain.Controls.Add(userControlStaffHome);
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
