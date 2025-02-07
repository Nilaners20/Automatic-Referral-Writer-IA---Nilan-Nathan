using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    public partial class CreateReferralPage : Form
    {
        public static string name { get; set; }
        public static string RefNum { get; set; }
        public static string DateIss { get; set; }
        public static string Reason { get; set; }
        public static string Intv { get; set; }

        private  string JsonFilePath;

       



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
            name = this.txtFirstLastName.Text;
            RefNum = this.txtEnterRefNum.Text;
            DateIss = this.txtDateIssued.Text;
            Reason = this.txtReason.Text;
            Intv = this.txtIntervention.Text;
            Student student = new Student();
            Student.NAME = name;
            Student.REFNUM = RefNum;
            Student.DATEISS = DateIss;
            Student.INTV = Intv;
            File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(movie));


            List<String> list = new List<string>(new string[] { name, RefNum, DateIss, Reason, Intv});
            String json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            



        }

        private void txtFirstLastName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void lblRefCreation(object sender, EventArgs e)
        {

        }

       
    }
}
