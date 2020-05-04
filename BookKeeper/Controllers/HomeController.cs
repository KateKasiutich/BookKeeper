using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookKeeper.Models;

namespace BookKeeper.Controllers
{
    public class HomeController : Controller
    {   
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }
    }
}