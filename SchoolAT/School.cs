using System;
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
    public partial class School : MetroFramework.Forms.MetroForm
    {
        public bool loggedin {  get; set; }
        public School()
        {
            InitializeComponent();
            loggedin = false;
        }

        private void School_Load(object sender, EventArgs e)
        {
            
        }

        private void School_Activated(object sender, EventArgs e)
        {
            LoginFrm newlogin = new LoginFrm();
            newlogin.ShowDialog();

            if (newlogin.loginFlag == false)
            {
                Close();
            }else
            {
                loggedin = true;
            }
        }
    }
}
