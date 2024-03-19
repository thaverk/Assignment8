using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class GamingHeadphones
    {
        [PrimaryKey,AutoIncrement]
        public int HeadphonesID { get; set; }
        public string Image {  get; set; }
        public string HeadphonesName { get; set; }
        public int HeadphonesQuantity { get; set; }
        public double HeadphonesPrice { get; set; }
    
    
    
    }
}
