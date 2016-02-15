using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.DataAccess;
using System.Windows.Forms;
namespace Hitech.Business
{
    /// <summary>
    /// Author:Xiao Su
    /// Date:2015-11-11
    /// Description:1.implement the interface 
    ///             2.set/get
    ///             3.overload to compare two clients
    /// </summary>
    public class Client : IOperation<Client>
    {

        //fields
       // public static int seq = 1000;
        private string clientId;
        private string clientType;
        private string clientName;
        private string street;
        private string city;
        private string province;
        private string postalCode;
        private string phoneNumber;
        private string fax;
        private double creaditLimit;
        private string email;

        //constructor
        public Client()
        {
        }

        public Client(string clientId, string clientName, string clientType, string street, string city, string province, string postalCode, string phoneNumber, string fax, double creaditLimit,string email)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.clientType = clientType;
            this.street = street;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
            this.Fax = fax;
            this.creaditLimit = creaditLimit;
            this.email = email;
        }

        //properties
        public string ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }     
        
        public string ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
     
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public double CreaditLimit
        {
            get { return creaditLimit; }
            set { creaditLimit = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        //implemtment the interface
        /// <summary>
        /// save to txt file by client object
        /// </summary>
        /// <param name="cli"></param>
        public  void SaveInformation(Client cli)
        {
            //TO-DO:validate
            ClientDataMangement.WriteClientDA(cli);
        }

        /// <summary>
        /// update the client's information
        /// </summary>
        /// <param name="oldCli"></param>
        /// <param name="newCli"></param>
        /// 
        public void UpdateInformation(Client oldCli, Client newCli)
        {
            //read the original txt
            List<Client> listOfOldClient = ClientDataMangement.ReadClientDA();
            List<Client> listOfNewClient = new List<Client>();
            //update the line
            foreach (Client aclient in listOfOldClient)
            {
                if (aclient.Equals(newCli))
                {
                    listOfNewClient.Add(newCli);
                }
                else
                {
                    listOfNewClient.Add(aclient);
                }
            }
            //delete file
            ClientDataMangement.DeleteClientFile();
            //save a new list
            foreach (Client newClient in listOfNewClient)
            {
                ClientDataMangement.WriteClientDA(newClient);
            }
        }

        /// <summary>
        /// update the client's information
        /// </summary>
        /// <param name="cli"></param>
        public void DeleteInformation(Client cli)
        {
            //read the original txt
            List<Client> listOfOldClient = ClientDataMangement.ReadClientDA();
            List<Client> listOfNewClient = new List<Client>();
            //delete the line
            foreach (Client aclient in listOfOldClient)
            {
                if (!aclient.Equals(cli))
                {
                    listOfNewClient.Add(aclient);
                }
            }
            //delete file
            ClientDataMangement.DeleteClientFile();
            //save a new list
            foreach (Client newClient in listOfNewClient)
            {
                ClientDataMangement.WriteClientDA(newClient);
            }
            
        }

        /// <summary>
        /// search the client's information  by client object
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        /// 
        public List<Client> SearchInformation(Client cli)
        {

            //read the original txt
            List<Client> listOfClient = ClientDataMangement.ReadClientDA();
            List<Client> listOfFound = new List<Client>();
            //add to found list
            foreach (Client aclient in listOfClient)
            {

                if (aclient.ClientId == cli.ClientId || aclient.ClientName == cli.ClientName || aclient.ClientType == cli.ClientType || aclient.PhoneNumber == cli.PhoneNumber || aclient.Email == cli.Email)
                {
                    listOfFound.Add(aclient);

                }
            }

            return listOfFound;
        }
        /// <summary>
        /// get the client 's information by client object
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        /// 
        public Client GetClientInformation(Client cli)
        {

            //read the original txt
            List<Client> listOfClient = ClientDataMangement.ReadClientDA();
            Client clientFound = new Client();
            //add to found list
            foreach (Client aclient in listOfClient)
            {

                if (aclient.ClientId == cli.ClientId || aclient.ClientName == cli.ClientName)
                {
                    clientFound=aclient;

                }
            }

            return clientFound;
        }

        /// <summary>
        /// get the client list from txt by DataAccess layer
        /// </summary>
        /// <returns></returns>
        public List<Client> ReadInformation()
        {
            List<Client> listOfClient=new List<Client>();
            listOfClient = ClientDataMangement.ReadClientDA();
            return listOfClient;
        }

        /// <summary>
        /// override Equals() and GetHashCode()  to compare two clients
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(System.Object obj)
        {

            Client otherClient = obj as Client;
            if (otherClient == null)
            {
                return false;
            }
            return this.ClientId.Equals(otherClient.ClientId);
        }

        public override int GetHashCode()
        {
            return this.ClientId.GetHashCode();
        }
    }
}
