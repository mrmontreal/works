using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.Business;


namespace HiTechDistribution.GUI.Main
{
    public partial class fmLogin : Form
    {
        public static Form f;
        private int typeNumber;

        public fmLogin()
        {
            InitializeComponent();
            f = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string empId = txtUserName.Text;
            string password = txtUserPwd.Text;

            User aUser = new User(empId, password);
            bool login = aUser.CheckUser(aUser);
            if (login)
            {          
                typeNumber = aUser.GetType(aUser);
                FormMain aForm = new GUI.Main.FormMain(typeNumber);
                aForm.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeUserPassword chUserPw = new ChangeUserPassword();
            chUserPw.Show();
            this.Visible=false;
        }
    }
}
