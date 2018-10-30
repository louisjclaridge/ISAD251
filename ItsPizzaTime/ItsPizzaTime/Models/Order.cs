using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItsPizzaTime.Models
{
    public class Order
    {
        public string orderID { get; set; }
        public string customerID { get; set; }
        public string orderAddress { get; set; }
        public int orderQuantity { get; set; }
    }
}