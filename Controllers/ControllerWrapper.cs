using MvcApplication17.Helpers;
using MvcApplication17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class ControllerWrapper : Controller
    {
        public DataModel Dm
        {
            get
            {
                DataModel result = null;

                SessionManager sm = new SessionManager();

                object dataModel = sm.Get("dataModel");
                if (dataModel != null)
                {
                    result = dataModel as DataModel;
                }
                else
                {
                    result = new DataModel();
                    sm.Set("dataModel", result);
                }

                return result;
            }
        }
    }
}
