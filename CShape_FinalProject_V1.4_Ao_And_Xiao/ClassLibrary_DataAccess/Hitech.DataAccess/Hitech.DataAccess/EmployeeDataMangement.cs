using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Hitech.Business;

namespace Hitech.DataAccess
{
    public static class EmployeeDataMangement
    {
        private static string pathEmployee = Application.StartupPath + "//Employees.dat";
        private static string pathEmployeeXML = Application.StartupPath + "//Employees.xml";
        
        /// <summary>
        /// write a employee information into Employees.dat file
        /// </summary>
        /// <param name="aUser"></param>
        public static void WriteEmployeeDA(Employee anEmployee)
        {
            StreamWriter sWriter = new StreamWriter(pathEmployee, true);
            sWriter.WriteLine(anEmployee.EmpId + "," + anEmployee.FirstName + "," + anEmployee.LastName+ "," + anEmployee.JobTitle);
            sWriter.Close();
        }

        /// <summary>
        /// read user information from Employees.dat file
        /// </summary>
        /// <returns>list of Employees</returns>
        public static List<Employee> ReadEmployeeDA()
        {
            List<Employee> listOfEmployees = new List<Employee>();
            if (File.Exists(pathEmployee))
            {
                using (StreamReader sReader = new StreamReader(pathEmployee))
                {
                    String line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string id = column[0];
                        string fn = column[1];
                        string ln = column[2];
                        string jobTitle = column[3];
                        Employee anEmployee = new Employee(id, fn,ln,jobTitle);
                        listOfEmployees.Add(anEmployee);
                        line = sReader.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Employees.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfEmployees;
        }


        /// <summary>
        /// delete the file
        /// </summary>
        public static void DeleteEmployeeFile()
        {
            if (File.Exists(pathEmployee))
            {
                File.Delete(pathEmployee);
            }
        }


        public static void WriteEmployeeXMLDA(Employee anEmployee)
        { 
        
        }
    }
}
