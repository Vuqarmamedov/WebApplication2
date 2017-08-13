using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProductModel
    {
       public string name { get; set; }
       public double price { get; set; }
       public int count { get; set; }
       public string description { get; set; }
    }
}