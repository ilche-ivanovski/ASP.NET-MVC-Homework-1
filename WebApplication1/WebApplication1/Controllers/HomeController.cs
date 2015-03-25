using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Colleagues
    {
        public string Name;
    }
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ages()
        {
            var ColleugeusAges = new List<int> {
                21,
                29,
                18

            };
            ViewBag.Ages = ColleugeusAges;
            return View(ColleugeusAges);
        }
        List<Colleagues> ColleugeusNames = new List<Colleagues>

            {
                new Colleagues { Name = "Ervo" },
                new Colleagues { Name = "Mona" },
                new Colleagues { Name = "Darko" },
                new Colleagues { Name = "Vladimir" }
            };
        public ActionResult Names()
        {
            return View(ColleugeusNames);
        }
        [OutputCache(Duration = 10)]
        public string Cache()
        {
            return DateTime.Now.ToString("T");

        }
    }
}