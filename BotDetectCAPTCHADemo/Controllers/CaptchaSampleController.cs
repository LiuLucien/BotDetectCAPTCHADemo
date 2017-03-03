using BotDetectCAPTCHADemo.Models.ViewModels;
using System.Web.Mvc;

namespace BotDetectCAPTCHADemo.Controllers
{
    public class CaptchaSampleController : Controller
    {
        // GET: CaptchaSample
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CaptchaViewModel model)
        {
            return View();
        }
    }
}