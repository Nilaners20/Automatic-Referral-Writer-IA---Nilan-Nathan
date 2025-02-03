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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            Hide();
        }

        private void btnRecordSearch_Click(object sender, EventArgs e)
        {
            new StudentLookupPage().Show();
            Hide();
        }

        private void btnNewReferral_Click(object sender, EventArgs e)
        {
            new CreateReferralPage().Show();
            Hide();
        }
    }
}
