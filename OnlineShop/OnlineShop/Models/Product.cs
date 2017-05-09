using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Product
    {
        public int Product_id { get; set; }
        public string Title { get; set; }
        public int Category_id { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public DateTime Add_date { get; set; }

       
    }
}