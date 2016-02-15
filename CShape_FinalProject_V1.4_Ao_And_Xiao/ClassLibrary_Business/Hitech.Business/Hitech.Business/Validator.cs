using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hitech.Business
{
    public static class Validator
    {
        //Infomation must be not neither null nor empty
        public static bool IsNotNull(string input)
        {

            if (String.IsNullOrEmpty(input.Trim()))
            {
                MessageBox.Show("The input must be not neither null nor empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        //The number must be a 4-digit number.
        public static bool IsValidNumber(string input)
        {
            if ((Regex.IsMatch(input.Trim(), @"^\d{4}$")))
            {
                return true;
            }
            else
            {
                MessageBox.Show("The number must be a 4-digit number.", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        //The first name / last name / job title contains only letters
        public static bool IsValidString(string input)
        {
            if ((Regex.IsMatch(input.Trim(), @"^[a-zA-Z ]+$")))
            {
                return true;
            }
            else
            {
                //MessageBox.Show(input.Trim());
                MessageBox.Show("The first name or last name or job title contains only letters.", "Invalid letters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
