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
    public partial class ChangeUserPassword : Form
    {
        public ChangeUserPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            fmLogin.f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empId = textBox1.Text;
            string password = textBox2.Text;

            User aOldUser = new User(empId, password);
            User findUser = aOldUser.GetUserInformation(empId);

            bool login = aOldUser.CheckUser(aOldUser);
            if (login)
            {
                string newPw1 = textBox3.Text;
                string newPw2 = textBox4.Text;
                if (newPw1==newPw2)
                {
                    User aNewUser = new User(empId,newPw1,findUser.UserType);
                    aNewUser.UpdateInformation(aOldUser,aNewUser);
                    MessageBox.Show("Password updated");
                    this.Close();
                    fmLogin.f.Show();
                }
                else
                {
                    MessageBox.Show("The two passwords do not match.");
                }

            }
        }
    }
}
