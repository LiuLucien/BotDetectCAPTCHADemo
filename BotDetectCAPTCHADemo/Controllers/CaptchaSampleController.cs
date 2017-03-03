using BotDetect.Web.Mvc;
using BotDetectCAPTCHADemo.Models.ViewModels;
using System.Linq;
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
        [CaptchaValidation("CaptchaCode", "ExampleCaptcha", "Incorrect CAPTCHA code!")]
        public ActionResult Index(CaptchaViewModel model)
        {
            string msg = null;
            if (!ModelState.IsValid)
            {
                msg = string.Join(";", ModelState.Values.SelectMany(e => e.Errors).Select(gh => gh.ErrorMessage));
            }
            else
            {
                msg = "驗證成功!";
            }
            TempData["msg"] = msg;

            return RedirectToAction("Index");
        }
    }
}