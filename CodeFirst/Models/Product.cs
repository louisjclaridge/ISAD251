using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public Product()
        {

        }
    }
}