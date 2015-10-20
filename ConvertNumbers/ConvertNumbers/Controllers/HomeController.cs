using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConvertNumbers.Models;

namespace ConvertNumbers.Controllers
{
    public class HomeController : Controller
    {
        NumbersContext db = new NumbersContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Convert(string value)
        {
            int number;
            if (!int.TryParse(value, out number))
            {
                ViewBag.Message = "It's not an integer number";
            }
            else if (number > 999999 || number < 1)
            {
                ViewBag.Message = "The number out of range";
            }
            else
            {
                Converter converter = new Converter(db);
                ViewBag.Message = converter.ConvertValue(number);
            }
            return View();
        }
    }
}
