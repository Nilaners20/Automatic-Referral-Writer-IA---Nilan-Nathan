using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    public partial class StudentViewerPage : Form
    {
        public StudentViewerPage()
        {
            InitializeComponent();
            if (StudentLookupPage.isEmpty)
            {
                lblNoStuFound.Visible = true;
            }
        }


        private void btnStudentRepBacktoHome_Click(object sender, EventArgs e)
        {
            new HomePage().Show(); 
            Hide();
        }

        private void lblNoStuFound_Click(object sender, EventArgs e)
        {

        }

        private void txtRepView_TextChanged(object sender, EventArgs e)
        {
            txtRepView.Text = StudentLookupPage.REPORT;
        }
    }
}
