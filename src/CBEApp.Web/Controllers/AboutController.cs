using System.Web.Mvc;

namespace CBEApp.Web.Controllers
{
    public class AboutController : CBEAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}