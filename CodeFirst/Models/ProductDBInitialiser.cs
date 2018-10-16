using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CodeFirst.Models
{
    public class ProductDBInitialiser : CreateDatabaseIfNotExists<ProductDB>
    {
        protected override void Seed(ProductDB context)
        {
            context.products.AddOrUpdate(p => p.ProductID, new Product { Product_Code = "A123", Product_Name = "Ballpoint Pens", Stock = 200, Price = (float)0.20 }, new Product { Product_Code = "A127", Product_Name = "Fountain Pens", Stock = 100, Price = (float)1.20 });

            context.orders.AddOrUpdate(o => o.Order_Number, new Order { Order_Number = 1, Order_Date = DateTime.Now });

            context.SaveChanges();

            var products = context.products.ToDictionary(p => p.Product_Code, p => p.ProductID);
            context.order_lines.AddOrUpdate(
                new Order_Line { Order_Number = 1, ProductID = products["A123"], Quantity = 2 }, 
                new Order_Line { Order_Number = 1, ProductID = products["A127"], Quantity = 1 }
                );


            context.SaveChanges();



        }
    }

}