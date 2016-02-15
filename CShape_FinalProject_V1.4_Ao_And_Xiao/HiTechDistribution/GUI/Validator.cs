using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HiTechDistribution.GUI
{
    public static class Validator
    {
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
        /// This method checks if the user's input is
        /// numeric and has the right size
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="size"></param>
        /// <returns>true if valid;otherwise,false</returns>
        public static bool IsValidEmpty(TextBox textBox)
        {
            if (textBox.Text.Trim() == ""||textBox.Text.Trim()==null)
            {
                MessageBox.Show(textBox.Tag + " does not comply with the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
            
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

        /// <summary>
        /// validater a object comboBox is filled
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true / false</returns>
        public static bool IsPresent(ComboBox cb)
        {
            if (cb.Text == "")
            {
                MessageBox.Show("Please enter " + cb.Tag + "\n", "Missing id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// validater a object textBox is filled with right size
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="size"></param>
        /// <returns>true / false</returns>
        public static bool IsRightSize(TextBox tb, int size)
        {
            if (tb.Text.Length == size)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input "+tb.Tag+" right size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// validater a object textBox is filled by numeric
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static bool IsNumeric(TextBox tb)
        {
            Regex rgx1 = new Regex(@"^[\d]*$");
            if (rgx1.IsMatch(tb.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please input " + tb.Tag + " digit number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// validater a object textBox is filled with valid price
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true / false</returns>
        public static bool IsValidPrice(TextBox tb)
        {

            Regex rgx1 = new Regex(@"^[1-9]{1,}\.?[0-9]{1,2}$");
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

        /// <summary>
        /// check the year is equal or smaller than this year.
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true / false</returns>
        public static bool IsValidYear(TextBox tb)
        {
            DateTime today = DateTime.Today;
            if (Int32.Parse(tb.Text)<=today.Year)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }          
        }


        /// <summary>
        /// validater a object textBox is filled with a comma
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true / false</returns>
        public static bool CheckComma(TextBox tb)
        {
            Regex rgx1 = new Regex(@"[\,]{1,}");
            if (rgx1.IsMatch(tb.Text))
            {                
                MessageBox.Show(tb.Tag + " has a comma, does not comply with the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;  
            }           
        }
    }
}
