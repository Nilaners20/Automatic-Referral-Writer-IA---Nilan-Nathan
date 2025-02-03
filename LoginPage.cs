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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void boxEnterEmpCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if (boxEnterEmpCode.Text.Equals("123098"))
            {
                new HomePage().Show();
                Hide();
            }
           
            else
            {
                lblWrongCode.Visible = true;
            }


           
            
           
        }
    }
}
