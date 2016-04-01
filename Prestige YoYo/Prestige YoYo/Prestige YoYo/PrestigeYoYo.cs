/*
    File: PrestigeYoYo.cs
    Name: Steven Johnston, Matthew Warren
    Assingment: Final project milestone one
    Date: 3/18/2016
*/

using System;
using System.Windows.Forms;
namespace Prestige_YoYo
{
    public partial class frmPrestigeYoYo : Form
    {
        DataAccess da;
        public frmPrestigeYoYo()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            da = new DataAccess(txtServer.Text,txtUser.Text,txtPassword.Text,txtDatabase.Text);
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtIn.Text += "Test 1: WorkArea,123j123g234hj234g234jh234h, Line0,QUEUE_PAINT,,3/15/2016 1:11:11 PM";
            txtDbMessage.Text += " Test 1: "+ da.InsertLog("WorkArea,123j123g234hj234g234jh234h, Line0,QUEUE_PAINT,,3/15/2016 1:11:11 PM").Replace(@"\\r\\n","\r\n");
            txtIn.Text += "Test 2: Moms house,123j123g234hj234g234jhffff, Line1,QUEUE_INSPECTION_1,,3/15/2016 1:11:12 PM";
            txtDbMessage.Text += " Test 2: " + da.InsertLog("Moms house,123j123g234hj234g234jhffff, Line1,QUEUE_INSPECTION_1,,3/15/2016 1:11:12 PM").Replace(@"\\r\\n", "\r\n");
            txtIn.Text += "Test 3: WorkArea,123j123g234hj234g234jsdfss, Line4,INSPECTION_1_SCRAP,WARPING,3/15/2016 1:11:11 PM";
            txtDbMessage.Text += " Test 3: " + da.InsertLog("Test 3: WorkArea,123j123g234hj234g234jsdfss, Line4,INSPECTION_1_SCRAP,WARPING,3/15/2016 1:11:11 PM").Replace(@"\\r\\n", "\r\n");
            txtIn.Text += "Test 4: WorkArea,123j123g234hj234g234jsdfss, Line4,INSPECTION_1_SCRAP,WARPING,3/15/2016 1:11:11 PM";
            txtDbMessage.Text += " Test 4: " + da.InsertLog("Test 3: WorkArea,123j123g234hj234g234jsdfss, Line4,INSPECTION_1_SCRAP,WARPING,3/15/2016 1:11:11 PM").Replace(@"\\r\\n", "\r\n");
        }
    }
}
