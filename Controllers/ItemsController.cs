using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class ItemsController : ControllerWrapper
    {
        //
        // GET: /Items/

        public ActionResult Index(string id)
        {
            return View("~/Views/Items/" + id + ".cshtml", Dm);
        }

    }
}
