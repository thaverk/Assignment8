using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class GamingConsoles
    {
        [PrimaryKey, AutoIncrement]
        public int productID { get; set; }
        public string Name { get; set; }  
        public string Description { get; set; }
        public double price { get; set; }  
        public int quantity { get; set; }

 
    }
}
