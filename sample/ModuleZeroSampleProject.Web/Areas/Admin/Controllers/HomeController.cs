using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ModuleZeroSampleProject.Web.Areas.Admin.Controllers
{
    public class HomeController : ModuleZeroSampleProjectControllerBase
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View(); //Layout of the angular application.
        }
    }
}