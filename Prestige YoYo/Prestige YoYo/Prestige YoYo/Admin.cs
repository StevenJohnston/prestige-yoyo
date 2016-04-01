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
    public partial class Admin : Form, myForm
    {
        private string userName;
        private string password;

        frmSelectFactory frmSelectFactory;
        string factory;

        frmSelectStation frmStation;
        string station;

        public Admin()
        {
            InitializeComponent();
        }

        public void setFactory(string newFactory)
        {
            factory = newFactory;
        }
        public void setStation(string newStation)
        {
            station = newStation;
        }

        public void setUserName(string newUserName)
        {
            userName = newUserName;
            this.Text += " - " + newUserName;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }



        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
