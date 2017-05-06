using MvcApplication17.Helpers;
using MvcApplication17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class HomeController : ControllerWrapper
    {
        public ActionResult Index()
        {
            return View(Dm);
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}
