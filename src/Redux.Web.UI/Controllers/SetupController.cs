using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redux.Web.Shared;

namespace Redux.Web.UI.Controllers
{
    public class SetupController : BaseController
    {
        //
        // GET: /Setup/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            if (formCollection.AllKeys.Contains("create"))
            {
                EntitiesRegistration.CreateSchema();
            }

            if (formCollection.AllKeys.Contains("drop"))
            {
                EntitiesRegistration.DropSchema();
            }

            return View();
        }

  

    }
}
