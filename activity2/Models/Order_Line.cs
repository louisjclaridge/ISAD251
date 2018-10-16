using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace activity2.Models
{
    public class Order_Line
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_LineID { get; set; }
        public int Order_Number { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
    }
}