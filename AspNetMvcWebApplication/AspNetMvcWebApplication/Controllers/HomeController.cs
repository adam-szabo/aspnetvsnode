using AspNetMvcWebApplication.Models;
using System;
using System.Web.Mvc;

namespace AspNetMvcWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new TimeViewModel { Time = DateTime.UtcNow.ToString("o") };
            return View(model);
        }
    }
}