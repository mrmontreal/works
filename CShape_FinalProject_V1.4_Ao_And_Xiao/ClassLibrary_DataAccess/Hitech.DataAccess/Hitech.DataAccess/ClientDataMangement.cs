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
    public static class ClientDataMangement
    {
        //define file path 
        private static string pathClient = Application.StartupPath + "//Clients.dat";
        //read file
        //--clientId,clientType,clientName,street,city,province,postalCode,phoneNumber,fax,creaditLimit,email
        //string clientId, string clientName, string clientType, string street, string city, string province, string postalCode, string phoneNumber, string fax, double creaditLimit
        public static List<Client> ReadClientDA()
        {
            List<Client> listOfClient = new List<Client>();
            //listOfClient = null;
            if (File.Exists(pathClient))
            {
                using (StreamReader sReader = new StreamReader(pathClient))
                {
                    String line = sReader.ReadLine();
                    while (line != null)
                    {
                        string[] column = line.Split(',');
                        string clientId = column[0];
                        string clientType = column[1];
                        string clientName = column[2];
                        string street = column[3];
                        string city = column[4];
                        string province = column[5];
                        string postalCode = column[6];
                        string phoneNumber = column[7];
                        string fax = column[8];
                        double creaditLimit = Double.Parse( column[9]);
                        string email = column[10];
                        Client aClient = new Client(clientId, clientName, clientType, street, city, province, postalCode, phoneNumber, fax, creaditLimit, email);
                        listOfClient.Add(aClient);
                        line = sReader.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no Clients.dat file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listOfClient;

        }
        //write file
        //--clientId,clientType,LastName,FirstName,street,city,province,postalCode,phoneNumber,fax,creaditLimit
        public static void WriteClientDA(Client cli)
        {
            StreamWriter sw = new StreamWriter(pathClient, true);
            sw.WriteLine(cli.ClientId + "," + cli.ClientType + "," + cli.ClientName + "," + cli.Street + "," + cli.City + "," + cli.Province + "," + cli.PostalCode + "," + cli.PhoneNumber + "," + cli.Fax + "," + cli.CreaditLimit + "," + cli.Email);
            sw.Close();
        }
        //delete file
        public static void DeleteClientFile()
        {
            //delete original txt
            File.WriteAllBytes(pathClient, new byte[0]);
        }

    }
}
