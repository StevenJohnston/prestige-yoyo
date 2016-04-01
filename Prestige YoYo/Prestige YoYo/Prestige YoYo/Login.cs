using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestige_YoYo
{
    public partial class Login : Form
    {
        myForm userForm;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isAdmin = txtUserName.Text == "admin";
            if (isAdmin)
            {
                userForm = new Admin();
            }
            else
            {
                userForm = new General_User();
            }
            userForm.setUserName(txtUserName.Text);
            userForm.setPassword(txtPassword.Text);
            ((Form)userForm).Show();
            this.Hide();
        }
    }
}
