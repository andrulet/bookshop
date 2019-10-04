using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;
using BookShop.Utill;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        BookContext db =new BookContext();
        
        public ActionResult GetImage()
        {
            string pathimage = "../Content/Image/Index.jpg";
            return new ImageResult(pathimage);
        }
        public ActionResult GetHtml()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetHtml(string html)
        {
            return new HtmlResult(html);
        }
        public string Square(int a, int b)
        {
            double s = a * b / 2;
            return $"<h3>Площадь треугольника равна {s}</h3>";
        }
        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int b = Int32.Parse(Request.Params["b"]);
            double s = a * b / 2;
            return $"<h3>Площадь треугольника равна {s}</h3>";
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public string PostBook()
        {
            string title = Request.Form["title"];
            string author = Request.Form["author"];
            return $"<h2>Название книги {title} и ее автор {author}</h2>";
        }
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int? Id)
        {
            ViewBag.BookId = Id??0;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.dateTime = DateTime.Now;
            //purchase.Address = (string)ViewBag.Adress;
            //purchase.Person = (string)ViewBag.Person;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}