using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Order_Line
    {
        public int Order_LineID { get; set; }
        public int Order_Number { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }

        public Order_Line()
        {

        }
    }
}