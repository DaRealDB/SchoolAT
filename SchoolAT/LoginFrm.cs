﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAT
{
    public partial class LoginFrm : Form
    {
        public bool loginFlag { get; set; }
        public LoginFrm()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void mbtn_login_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.userSATTableAdapter userAda =  new DataSet1TableAdapters.userSATTableAdapter();

            DataTable dt = userAda.GetDataByGetUserandPass(mtxb_user.Text, mtxb_pass.Text);

           if (dt.Rows.Count > 0 )
            {
                loginFlag = true;
            }
            else
            {
                loginFlag = false;
            }
           Close();
        }
    }
}
