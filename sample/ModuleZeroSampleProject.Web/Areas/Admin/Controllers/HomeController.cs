using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using ModuleZeroSampleProject.Navigation;

namespace ModuleZeroSampleProject.Web.Areas.Admin.Controllers
{
    public class HomeController : ModuleZeroSampleProjectControllerBase
    {
        private readonly INavigationAppService _navigationAppService;

        public HomeController(INavigationAppService navigationAppService)
        {
            _navigationAppService = navigationAppService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            var list = _navigationAppService.GetNavigations();

            return View(); //Layout of the angular application.
        }
    }
}