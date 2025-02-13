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
using System.IO;

namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    public partial class CreateReferralPage : Form
    {
        public string name { get; set; }
        public string RefNum { get; set; }
        public string DateIss { get; set; }
        public string Reason { get; set; }
        public static string Intv { get; set; }

        private string JsonFilePath;

        public static string FinalText;
        public static string FINALTEXT;


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
           
            Student STUDENT = new Student 
            {
                NAME = name,
                REFNUM = RefNum,
                DATEISS = DateIss,
                REASON = Reason,
                INTV = Intv,
            };
            if (Intv == "Y")
            {
                FinalText = "The student " + name + " is receiving a referral for the following reason: " + Reason + " Invervention has been handled by the teacher already. ";
                Console.WriteLine(FinalText);
            }
            else
            {
                FinalText = "The student " + name + " is receiving a referral for the following reason: " + Reason;
                Console.WriteLine(FinalText);
            }
            FINALTEXT = FinalText;

            //using (StreamWriter file = File.CreateText(@"c:\"+ name + ".json"))
            // {
            //     JsonSerializer serializer = new JsonSerializer();
            //     serializer.Serialize(file, STUDENT);
            // }


        }

        private void txtFirstLastName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void lblRefCreation(object sender, EventArgs e)
        {

        }

       
    }
}
