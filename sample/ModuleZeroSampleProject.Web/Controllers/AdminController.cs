using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ModuleZeroSampleProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AdminController : ModuleZeroSampleProjectControllerBase
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
    }
}