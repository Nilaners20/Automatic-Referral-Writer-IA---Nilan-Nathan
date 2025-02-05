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
    public partial class FinalTextPage : Form
    {
        public FinalTextPage()
        {
            InitializeComponent();
        }

        private void btnFinalTextBackToHome_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }

        private void txtFinalText_TextChanged(object sender, EventArgs e)
        {
            if (CreateReferralPage.Intv == "Y")
            {
                txtFinalText.Text = "The student " + CreateReferralPage.name + " is receiving a for the following reason: " + CreateReferralPage.Reason + " Invervention has been handled by the teacher already. ";
            }
            else
            {
                txtFinalText.Text = "The student " + CreateReferralPage.name + " is receiving a for the following reason: " + CreateReferralPage.Reason;
            }
           
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtFinalText.Text);
            lblRefCreated.Visible = true;

        }

        private void lblRefCreated_Click(object sender, EventArgs e)
        {

        }
    }
}
