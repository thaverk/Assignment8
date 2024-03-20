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
<<<<<<< HEAD
            _dbconnection.CreateTable<GamingHeadphones>();
=======
>>>>>>> 1bfc197c3e0344d4358791fd63677fb1c9271785
            SeedDatabase();
        }



<<<<<<< HEAD
        public void SeedClient()
        {
            if (_dbconnection.Table<Client>().Count() == 0)
=======
        public void SeedDatabase() 
        {
         if (_dbconnection.Table<Client>().Count()==0) 
>>>>>>> 1bfc197c3e0344d4358791fd63677fb1c9271785
            {
                Client client = new Client()
                {
                    ClientName = "",
                    ClientSurname = "",
                    ClientEmail = "",
<<<<<<< HEAD

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
=======
                   
                 };
            _dbconnection.Insert(client);
            }
        
        }

>>>>>>> 1bfc197c3e0344d4358791fd63677fb1c9271785
        public Client GetClientById(int id)
        {
            Client client = _dbconnection.Table<Client>().Where(x => x.ClientId == id).FirstOrDefault();

            if (client != null)
                _dbconnection.GetChildren(client, true);

            return client;
        }

        public void UpdateClient(Client client)
        {
<<<<<<< HEAD
            SeedClient(); 
=======
            SeedDatabase(); 
>>>>>>> 1bfc197c3e0344d4358791fd63677fb1c9271785
            _dbconnection.Update(client);
        }

        public void SaveClient(Client client)
        {

            _dbconnection.Insert(client);

        }
<<<<<<< HEAD

       public List<GamingHeadphones> GetGamingHeadphones() 
        {

            return _dbconnection.Table<GamingHeadphones>().ToList();
        }
=======
       

>>>>>>> 1bfc197c3e0344d4358791fd63677fb1c9271785






    }
}
