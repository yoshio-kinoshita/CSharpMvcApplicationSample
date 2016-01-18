using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationSample.Controllers
{
    public class BeginController : Controller
    {
        //
        // GET: /Begin/

        public ActionResult Index()
        {
            return Content("こんにちは、世界！");
        }

    }
}
