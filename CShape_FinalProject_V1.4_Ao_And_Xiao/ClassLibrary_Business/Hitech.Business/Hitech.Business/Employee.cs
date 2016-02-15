using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.DataAccess;

namespace Hitech.Business
{
    /// <summary>
    /// Author:Ao Hu
    /// Date:2015-11-11
    /// Description:1.implement the interface 
    ///             2.set/get
    ///             3.overload to compare two employees
    ///             4.create user for this employee
    ///             5.only delete employee information
    ///             6.search Employee by id
    /// </summary>
    public class Employee : Person, IOperation<Employee>
    {
        //- empId:string
        //- jobTitle:string

        //fileds
        private string empId;
        private string jobTitle;
        private User aUser;

        //constructor
        public Employee(string empId, string firstName, string lastName, string jobTitle)
        {
            this.EmpId = empId;
            base.FirstName = firstName;
            base.LastName = lastName;  
            this.JobTitle = jobTitle;
            this.aUser = new User(empId, "1234");
        }

        public Employee() { }

        //properities
        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public User AUser
        {
            get { return aUser; }
            set { aUser = value; }
        }

        //implemtment the interface
        /// <summary>
        /// save an employee to file
        /// </summary>
        /// <param name="emp"></param>
        public void SaveInformation(Employee emp)
        {
            EmployeeDataMangement.WriteEmployeeDA(emp);
            CreateUser();     //create user information, composition relationship
            UserDataMangement.WriteUserDA(aUser);
        }

        /// <summary>
        /// update an employee information in the file
        /// </summary>
        /// <param name="oldEmp"></param>
        /// <param name="newEmp"></param>
        public void UpdateInformation(Employee oldEmp, Employee newEmp)
        {
            //only update employee file

            //read the original txt
            List<Employee> listOfOldEmployee = EmployeeDataMangement.ReadEmployeeDA();
            List<Employee> listOfNewEmployee = new List<Employee>();
            //update the line
            foreach (Employee anEmployee in listOfOldEmployee)
            {
                if (anEmployee.Equals(newEmp))
                {
                    listOfNewEmployee.Add(newEmp);
                }
                else
                {
                    listOfNewEmployee.Add(anEmployee);
                }
            }
            //delete file
            EmployeeDataMangement.DeleteEmployeeFile();
            //save a new list
            foreach (Employee aNewEmployee in listOfNewEmployee)
            {
                EmployeeDataMangement.WriteEmployeeDA(aNewEmployee);
            }

        }

        /// <summary>
        /// delete an employee an user associated with this employee in the file
        /// </summary>
        /// <param name="emp"></param>
        public void DeleteInformation(Employee emp)
        {
            //delete the user associated with this employee
            emp.aUser.DeleteInformation(emp.aUser);

            //read the original txt
            List<Employee> listOfOldEmployee = EmployeeDataMangement.ReadEmployeeDA();
            List<Employee> listOfNewEmployee = new List<Employee>();
            //delete the line
            foreach (Employee anEmployee in listOfOldEmployee)
            {
                if (!anEmployee.Equals(emp))
                {
                    listOfNewEmployee.Add(anEmployee);
                }
            }
            //delete file
            EmployeeDataMangement.DeleteEmployeeFile();
            //save a new list
            foreach (Employee newEmployee in listOfNewEmployee)
            {
                EmployeeDataMangement.WriteEmployeeDA(newEmployee);
            }
        }

        /// <summary>
        /// only delete employee information
        /// </summary>
        /// <param name="emp"></param>
        public void DeleteEmployeeInformation(Employee emp)
        {
            //read the original txt
            List<Employee> listOfOldEmployee = EmployeeDataMangement.ReadEmployeeDA();
            List<Employee> listOfNewEmployee = new List<Employee>();
            //delete the line
            foreach (Employee anEmployee in listOfOldEmployee)
            {
                if (!anEmployee.Equals(emp))
                {
                    listOfNewEmployee.Add(anEmployee);
                }
            }
            //delete file
            EmployeeDataMangement.DeleteEmployeeFile();
            //save a new list
            foreach (Employee newEmployee in listOfNewEmployee)
            {
                EmployeeDataMangement.WriteEmployeeDA(newEmployee);
            }
        }

        /// <summary>
        /// search employee information according to object emp
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>list of employee</returns>
        public List<Employee> SearchInformation(Employee emp)
        {
            //read the original txt
            List<Employee> listOfEmployee = EmployeeDataMangement.ReadEmployeeDA();
            List<Employee> listOfFound = new List<Employee>();
            //add to found list
            foreach (Employee anEmployee in listOfEmployee)
            {
                if ((emp.empId != "") && (anEmployee.empId==emp.empId))
                {
                    listOfFound.Add(anEmployee);
                    break;
                }
                else if ((emp.FirstName != "") && (anEmployee.FirstName == emp.FirstName))
                {
                    listOfFound.Add(anEmployee);
                }
                else if ((emp.LastName != "") && (anEmployee.LastName==emp.LastName))
                {
                    listOfFound.Add(anEmployee);
                }
            }
            return listOfFound;
        }

        /// <summary>
        /// search Employee by id
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>Employee/null</returns>
        public Employee GetEmployeeInformation(String empId)
        {
            //read the original txt
            List<Employee> listOfEmployee = EmployeeDataMangement.ReadEmployeeDA();
            Employee findEmployee = null;
            //add to found list
            foreach (Employee anEmployee in listOfEmployee)
            {
                if (anEmployee.empId == empId)
                {
                    findEmployee=anEmployee;
                    break;
                }
            }
            return findEmployee;
        }

        /// <summary>
        /// read employee informations from file
        /// </summary>
        /// <returns>list of employee</returns>
        public List<Employee> ReadInformation()
        {
            //throw new NotImplementedException();
            List<Employee> listOfEmployees = EmployeeDataMangement.ReadEmployeeDA();
            return listOfEmployees;
        }

        /// <summary>
        /// create user for this employee
        /// </summary>
        public void CreateUser()
        {
            this.aUser = new User(empId,"1234");
        }

        /// <summary>
        /// judge an employee is equal to other employee or not 
        /// </summary>
        /// <param name="obj">other employee</param>
        /// <returns>true/false</returns>
        public override bool Equals(System.Object obj)
        {
            Employee otherEmployee = (Employee)obj;
            if (empId == otherEmployee.empId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// override get hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.empId.GetHashCode();
        }
    }
}
