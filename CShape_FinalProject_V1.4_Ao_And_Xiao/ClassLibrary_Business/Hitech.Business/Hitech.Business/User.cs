using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.DataAccess;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hitech.Business
{
    /// <summary>
    /// Author:Ao Hu
    /// Date:2015-11-11
    /// Description:1.implement the interface 
    ///             2.set/get
    ///             3.this User class is used to check user name and password when employee login
    ///             4.save new password in the file when the employee change the password 
    ///             5.serialize attributes to streaming context
    ///             6.deserialize from streaming context to attirbute
    ///             7.get user type of a user
    /// </summary>
    /// 

    [Serializable]
    public class User : IOperation<User>, ISerializable
    {
        //- empId:string
        //- pwd:string
        //- userType:int

        //fields
        private string empId;
        private string password;
        private int userType;

        //constructor
        public User(string empId, string password)
        {
            this.EmpId = empId;
            this.Password = password;
            this.userType = 1;
        }

        public User(string empId, string password, int userType)
        {
            this.EmpId = empId;
            this.Password = password;
            this.userType = userType;
        }

        public User() { }

        //properties

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        //implemtment the interface

        /// <summary>
        /// save an user to file
        /// </summary>
        /// <param name="user"></param>
        public void SaveInformation(User user)
        {
            UserDataMangement.WriteUserDA(user);

        }

        /// <summary>
        /// update an user information in the file
        /// </summary>
        /// <param name="oldUser"></param>
        /// <param name="newUser"></param>
        public void UpdateInformation(User oldUser, User newUser)
        {
            //read the original txt
            List<User> listOfOldUser = UserDataMangement.ReadUserDA();
            List<User> listOfNewUser = new List<User>();
            //update the line
            foreach (User aUser in listOfOldUser)
            {
                if (aUser.empId==newUser.empId)
                {
                    listOfNewUser.Add(newUser);
                }
                else
                {
                    listOfNewUser.Add(aUser);
                }
            }
            //delete file
            UserDataMangement.DeleteUserFile();
            //save a new list
            foreach (User aNewUser in listOfNewUser)
            {
                UserDataMangement.WriteUserDA(aNewUser);
            }
        }

        /// <summary>
        /// delete an user in the file
        /// </summary>
        /// <param name="user"></param>
        public void DeleteInformation(User user)
        {
            //read the original txt
            List<User> listOfOldUser = UserDataMangement.ReadUserDA();
            List<User> listOfNewUser = new List<User>();
            //delete the line
            foreach (User aUser in listOfOldUser)
            {
                if (!aUser.Equals(user))
                {
                    listOfNewUser.Add(aUser);
                }
            }
            //delete file
            UserDataMangement.DeleteUserFile();
            //save a new list
            foreach (User newUser in listOfNewUser)
            {
                UserDataMangement.WriteUserDA(newUser);
            }
        }

        /// <summary>
        /// read user informations from file
        /// </summary>
        /// <returns>List of user</returns>
        public List<User> ReadInformation()
        {
            List<User> listOfUser = new List<User>();
            listOfUser = UserDataMangement.ReadUserDA();
            return listOfUser;
        }

        /// <summary>
        /// search a list of user according to parameter
        /// </summary>
        /// <param name="user"></param>
        /// <returns>list of users</returns>
        public List<User> SearchInformation(User user)
        {
            //read the original txt
            List<User> listOfUser = UserDataMangement.ReadUserDA();
            List<User> listOfFound = new List<User>();
            //add to found list
            foreach (User aUser in listOfUser)
            {
                if ((user.empId != "")&&(aUser.empId==user.empId))
                {
                    listOfFound.Add(aUser);
                    break;
                }
                else if ((user.UserType != 0) && (aUser.userType == user.userType))
                {
                    listOfFound.Add(aUser);
                }
            }
            return listOfFound;
        }

        /// <summary>
        /// serialize attributes to streaming context
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        public virtual void GetObjectData(SerializationInfo s, StreamingContext c)
        {
            s.AddValue("UserName", empId);
            s.AddValue("Password", password);
            s.AddValue("UserType", userType);
        }

        /// <summary>
        /// deserialize from streaming context to attirbute
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        private User(SerializationInfo s, StreamingContext c)
        {
            empId = s.GetString("UserName");
            password = s.GetString("Password");
            userType = s.GetInt32("UserType");
        }
        /// <summary>
        /// search user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a user/null</returns>
        public User GetUserInformation(String empId)
        {
            User aUserFound = null;
            //read the original txt
            List<User> listOfUser = UserDataMangement.ReadUserDA();
            //add to found list
            foreach (User aUser in listOfUser)
            {
                if (aUser.empId == empId)
                {
                    aUserFound=aUser;
                    break;
                }
            }
            return aUserFound;
        }


        /// <summary>
        /// check a user is in the file,it means that user name and password all are correct
        /// </summary>
        /// <param name="aUser">a user object</param>
        /// <returns>true/false</returns>
        public bool CheckUser(User aUser)
        {
            List<User> list = UserDataMangement.ReadUserDA();
            bool find = false;
            foreach (var item in list)
            {
                if (item.Equals(aUser))
                {
                    find = true;
                    break;
                }
            }
            if (find == false)
            {
                MessageBox.Show("Wrong Employee ID or Password, please retry.");
            }
            return find;
        }

        /// <summary>
        /// get user type of a user
        /// </summary>
        /// <param name="aUser"></param>
        /// <returns>typeNumber</returns>
        public int GetType(User aUser)
        {
            int typeNumber = 0;
            List<User> list = UserDataMangement.ReadUserDA();
            foreach (var item in list)
            {
                if (item.Equals(aUser))
                {
                    typeNumber = item.UserType;
                    break;
                }
            }
            return typeNumber;
        }

        /// <summary>
        /// judge aUser is equal to other User or not 
        /// </summary>
        /// <param name="obj">other user</param>
        /// <returns>true/false</returns>
        public override bool Equals(System.Object obj)
        {
            User otherUser = (User)obj;
            if ((empId == otherUser.empId) && (password == otherUser.password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.empId.GetHashCode();
        }
    }
}
