using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CBEApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CBEAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}