using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItsPizzaTime.Models
{
    public class Pizza
    {
        public string pizzaID { get; set; }
        public string customerID { get; set; }
        public string orderID { get; set; }
        public string pizzaInfo { get; set; }
    }
}