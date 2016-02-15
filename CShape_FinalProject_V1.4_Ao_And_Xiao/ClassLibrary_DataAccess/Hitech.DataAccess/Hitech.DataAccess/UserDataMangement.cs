using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Hitech.Business;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Hitech.DataAccess
{
    public static class UserDataMangement
    {
        //user.dat file location
        //private static string pathUser = Application.StartupPath + "//Users.dat";
        private static string pathUserBinfile = Application.StartupPath + "//Users.bin";

        /// <summary>
        /// read user information from users.bin file
        /// </summary>
        /// <returns>list of users</returns>
        public static List<User> ReadUserDA()
        {
            List<User> listOfUser = new List<User>();

            // Deserialize one Insect
            Stream sr = File.Open(pathUserBinfile, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            while (sr.Position != sr.Length)
            {
                User j = (User)bf.Deserialize(sr);
                listOfUser.Add(j);
            }
            sr.Close();
            return listOfUser;
        }


        /// <summary>
        /// write a user information into users.bin file
        /// </summary>
        /// <param name="aUser"></param>
        public static void WriteUserDA(User aUser)
        {
            if (File.Exists(pathUserBinfile))
            {
                using (Stream ss = File.Open(pathUserBinfile, FileMode.Append))
                {
                    BinaryFormatter bb = new BinaryFormatter();
                    bb.Serialize(ss, aUser);
                }
            }
            else
            {
                using (Stream ss = File.Create(pathUserBinfile))
                {
                    BinaryFormatter bb = new BinaryFormatter();
                    bb.Serialize(ss, aUser);
                }
            }
        }


        /// <summary>
        /// delete the file
        /// </summary>
        public static void DeleteUserFile()
        {
            if (File.Exists(pathUserBinfile))
            {
                File.Delete(pathUserBinfile);
            }
        }
    }
}
