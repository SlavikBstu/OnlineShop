using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Address
    {
        public int Address_id { get; set; }
        public int User_id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number_of_house { get; set; }
        public int Number_of_flat { get; set; }
        public int Email_index { get; set; }
    }
}