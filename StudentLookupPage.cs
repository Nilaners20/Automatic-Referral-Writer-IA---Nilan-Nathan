using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Automatic_Referral_Writer_IA___Nilan_Nathan
{
    public partial class StudentLookupPage : Form
    {
        public static string query { get; set; } 
        public static Boolean isEmpty { get; set; }
        public StudentLookupPage()
        {
            InitializeComponent();
        }

        private void btnStudentLookBacktoHome_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            
            query = boxFindStudent.Text;
            try
            {
                string REPORT = (File.ReadAllText("C:\\Users\\s324051\\Documents\\REFERRAL DATA\\" + query + ".json"));

            }
            catch (FileNotFoundException)
            {
                isEmpty = true;
                string REPORT = null;
            }
            new StudentViewerPage().Show();


        }

        private void boxFindStudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
