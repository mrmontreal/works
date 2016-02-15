using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EmployeeValidator
{
    public partial class EmployeeValidator: UserControl
    {
        //attribute
        private string employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private bool valid;


        //get and set
        public bool Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        public string EmployeeId
        {
            get { return employeeId; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
        }

        public EmployeeValidator()
        {
            InitializeComponent();
        }

        public void buttonValidate_Click(object sender, EventArgs e)
        {
            if (IsValidNumber(textBoxEmployeeID, 4) && CheckName(textBoxFname) && CheckName(textBoxLname) && IsPresent(textBoxJobTitle))
            {
                employeeId = textBoxEmployeeID.Text;
                firstName = textBoxFname.Text;
                lastName = textBoxLname.Text;
                jobTitle = textBoxJobTitle.Text;
                valid = true;
                MessageBox.Show("Data is valid.", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                valid = false;
            }
        }



        /// <summary>
        /// This method checks if the user's input is
        /// numeric and has the right size
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="size"></param>
        /// <returns>true if valid;otherwise,false</returns>
        public static bool IsValidNumber(TextBox textBox, int size)
        {
            if (!(Regex.IsMatch(textBox.Text, @"^\d{" + size + "}$")))
            {
                MessageBox.Show(textBox.Tag + " does not comply with the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// validater a object textBox is filled
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true / false</returns>
        public static bool IsPresent(TextBox tb)
        {
            if (tb.Text == "")
            {
                MessageBox.Show("Please enter " + tb.Tag + "\n", "Missing id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsRightSize(TextBox tb, int size)
        {
            if (tb.Text.Length == size)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter 4-digit id", "Missing id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool IsNumeric(TextBox tb)
        {
            Int32 myInt = 0;
            if (Int32.TryParse(tb.Text, out myInt))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter 4-digit id", "Missing id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// validater input string is a string more than 2 words
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true / false</returns>
        public static bool CheckName(TextBox tb)
        {
            Regex rgx1 = new Regex(@"^[a-zA-Z]{2,}$");
            if (rgx1.IsMatch(tb.Text))
            {

                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " does not comply with the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
