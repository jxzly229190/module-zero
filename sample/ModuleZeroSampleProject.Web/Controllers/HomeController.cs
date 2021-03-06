using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ModuleZeroSampleProject.Web.Controllers
{
    public class HomeController : ModuleZeroSampleProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}