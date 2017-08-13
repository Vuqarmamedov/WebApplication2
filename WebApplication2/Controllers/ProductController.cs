using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult info()
        {
            //ProductModel pm = new ProductModel()
            //{
            //    count = 5,
            //    description = "my new project",
            //    name = "product a",
            //    price = 15
            //};

            List<Category> cat = new List<Category>()
            {
               new Category
               {
                ad ="mawin",
                sayi=1,
                desc="menim mawinim"
               },
               new Category
               {
                   ad="mawin 2",
                   sayi=2,
                   desc="onun mawini"
               },
               new Category
               {
                   ad="mawin 2",
                   sayi=3,
                   desc="dostumun mawini"
               }

            };
            return View("details", cat);
        }
    }
}