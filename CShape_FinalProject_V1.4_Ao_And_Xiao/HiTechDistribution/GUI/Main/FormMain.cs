using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechDistribution.GUI.Main
{
    public partial class FormMain : Form
    {
        private int typeNumber;

        public int TypeNumber
        {
            get { return typeNumber; }
            set { typeNumber = value; }
        }

        public FormMain(int type)
        {
            InitializeComponent();
            this.typeNumber = type;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit this application?", "Exit?", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes)) 
                this.Close();
            fmLogin fl = new fmLogin();
            fl.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (typeNumber==1)
            {  
                manageOrderInformationToolStripMenuItem.Enabled = true;
                addNewOrderToolStripMenuItem.Enabled = true;
            }
            else if (typeNumber==2)
            {
                manageProductInformationToolStripMenuItem1.Enabled = true;
                modifyProductInventoryToolStripMenuItem.Enabled = true;                
            }
            else if (typeNumber==3)
            {
                manageClientInformationToolStripMenuItem.Enabled = true;
            }
            else if (typeNumber == 4)
            {
                employeeManagementToolStripMenuItem.Enabled = true;
                userManagementToolStripMenuItem.Enabled = true; 
            }
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkEmp = new EmployeeGUI.CheckEmpInformation();
            checkEmp.Show();
        }

        private void manageProductInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var chkPro = new GUI.ProductGUI.CheckProductInformation();
            chkPro.Show();
        }

        private void modifyProductInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modItem = new GUI.ProductGUI.ModProductInventory();
            modItem.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkUser = new UserGUI.CheckUserInformation();
            checkUser.Show();
        }

        private void manageClientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkClient = new ClientGUI.FormClient();
            checkClient.Show();
        }

        private void manageOrderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkOrder = new OrderGUI.FormListOfOrder();
            checkOrder.Show();
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addOrder = new OrderGUI.FormAddOrder();
            addOrder.Show();
        }

    }
}
