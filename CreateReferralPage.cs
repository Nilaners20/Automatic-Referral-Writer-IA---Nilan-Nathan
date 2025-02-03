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
    public partial class CreateReferralPage : Form
    {
        public CreateReferralPage()
        {
            InitializeComponent();
        }

        private void txtEnterRefNum_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePageBack2Home_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }

        private void btnCreateReferral_Click(object sender, EventArgs e)
        {
            new FinalTextPage().Show();
            Hide();
        }
    }
}
