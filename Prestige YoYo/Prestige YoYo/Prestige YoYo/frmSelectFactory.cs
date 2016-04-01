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
    public partial class frmSelectFactory : Form
    {
        myForm thisParentForm;
        public frmSelectFactory(Form newParentForm)
        {
            thisParentForm = (myForm)newParentForm;
            InitializeComponent();
        }

        private void btnSelectFactory_Click(object sender, EventArgs e)
        {
            string factoryName = lstFactories.GetItemText(lstFactories.SelectedItem);
            thisParentForm.setFactory(factoryName);
            Close();
        }
    }
}
