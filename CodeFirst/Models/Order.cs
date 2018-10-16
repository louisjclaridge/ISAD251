using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst.Models
{
    public class Order
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Number { get; set; }
        public DateTime Order_Date { get; set; }
        public virtual ICollection<Order_Line> Order_Lines { get; set; }

        public Order()
        {

        }
    }
}