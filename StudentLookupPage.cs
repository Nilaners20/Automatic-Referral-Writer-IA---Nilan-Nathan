﻿using System;
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
    public partial class StudentLookupPage : Form
    {
        public StudentLookupPage()
        {
            InitializeComponent();
        }

        private void btnStudentLookBacktoHome_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }
    }
}
