using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            txtFinalText.Text = CreateReferralPage.FinalText;

        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtFinalText.Text);
            lblRefCopied.Visible = true;

        }

        private void lblRefCreated_Click(object sender, EventArgs e)
        {

        }
    }
}
