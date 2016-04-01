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
    public partial class frmSelectStation : Form
    {
        string factory;
        myForm thisParentForm;

        public frmSelectStation(Form newParentForm)
        {
            thisParentForm = (myForm)newParentForm;
            InitializeComponent();
        }

        public void setFactory(string newFactory)
        {
            factory = newFactory;
        }

        private void btnSelectStation_Click(object sender, EventArgs e)
        {
            string stationName = lstStations.GetItemText(lstStations.SelectedItem);
            thisParentForm.setStation(stationName);
            Close();
        }
    }
}
