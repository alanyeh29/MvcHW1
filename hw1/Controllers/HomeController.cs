using hw1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace hw1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random rnd = new Random();
            var model = new List<money>();
            money note;
            for (int i = 0; i < 200; i++)
            {
                note = new money();
                int rand = rnd.Next(2);
                if (rand == 1)
                    note.Class = "支出";
                else
                    note.Class = "收入";
                note.Date = DateTime.Now.AddDays(rnd.Next(3650));
                note.Money = rnd.Next(10000);
                model.Add(note);
            }
            return View(model);
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