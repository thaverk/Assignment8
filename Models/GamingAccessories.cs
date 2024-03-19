using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class GamingAccessories
    {
        [PrimaryKey,AutoIncrement]
        public int AccessoriesID { get; set; }
        public string name { get; set; }
        public string productImage { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        
        
    
    
    
    
    }
}
