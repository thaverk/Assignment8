using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models;
using SQLiteNetExtensions.Extensions;


namespace ShoppingCart.Services
{
    public class AppDataBase
    {
        public SQLiteConnection _dbconnection;

        public string GetDatabasePath()

        {
            string filename = "AppDatabase.db";

            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return pathToDb + filename;

        }



        public AppDataBase()
        {
            _dbconnection = new SQLiteConnection(GetDatabasePath());
            _dbconnection.CreateTable<Client>();
            SeedDatabase();
        }



        public void SeedDatabase() 
        {
         if (_dbconnection.Table<Client>().Count()==0) 
            {
                Client client = new Client()
                {
                    ClientName = "",
                    ClientSurname = "",
                    ClientEmail = "",
                   
                 };
            _dbconnection.Insert(client);
            }
        
        }

        public Client GetClientById(int id)
        {
            Client client = _dbconnection.Table<Client>().Where(x => x.ClientId == id).FirstOrDefault();

            if (client != null)
                _dbconnection.GetChildren(client, true);

            return client;
        }

        public void UpdateClient(Client client)
        {
            SeedDatabase(); 
            _dbconnection.Update(client);
        }

        public void SaveClient(Client client)
        {

            _dbconnection.Insert(client);

        }
       







    }
}
