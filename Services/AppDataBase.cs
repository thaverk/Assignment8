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
            _dbconnection.CreateTable<GamingHeadphones>();
            SeedDatabase();
        }



        public void SeedClient()
        {
            if (_dbconnection.Table<Client>().Count() == 0)
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
           
        public void SeedDatabase() 
        {
            if (_dbconnection.Table<GamingHeadphones>().Count() == 0)
            {

                GamingHeadphones gamingHeadphones = new GamingHeadphones()
                {

                    Image = "tb_ear_force_recon_chat.png",
                    HeadphonesName = "Turtle Beach Ear Force REcon Chat",
                    HeadphonesQuantity = 50,
                    HeadphonesPrice = 1500,
                };
                _dbconnection.Insert(gamingHeadphones);

                gamingHeadphones = new GamingHeadphones()
                {

                    Image = "tb_recon_50x.png",
                    HeadphonesName = "Turtle Beach Recon 50X (PS5)",
                    HeadphonesQuantity = 50,
                    HeadphonesPrice = 2000,
                };
                _dbconnection.Insert(gamingHeadphones);

                gamingHeadphones = new GamingHeadphones()
                {

                    Image = "tb_stealth_600_gen_2.png",
                    HeadphonesName = "Turtle Beach Stealth 600 Gen 2",
                    HeadphonesQuantity = 50,
                    HeadphonesPrice = 2000,

                };


                _dbconnection.Insert(gamingHeadphones);
            }
        }

        public void SaveHeadphones(GamingHeadphones headphones) 
        {
            _dbconnection.Insert(headphones);
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
            SeedClient(); 
            _dbconnection.Update(client);
        }

        public void SaveClient(Client client)
        {

            _dbconnection.Insert(client);

        }

       public List<GamingHeadphones> GetGamingHeadphones() 
        {

            return _dbconnection.Table<GamingHeadphones>().ToList();
        }






    }
}
