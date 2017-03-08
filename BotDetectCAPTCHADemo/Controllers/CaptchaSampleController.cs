using BotDetect.Web.Mvc;
using BotDetectCAPTCHADemo.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace BotDetectCAPTCHADemo.Controllers
{
    public class CaptchaSampleController : Controller
    {
        // 基本範例 後端驗證
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
                //重啟Captcha
                MvcCaptcha.ResetCaptcha("ExampleCaptcha");
            }
            TempData["msg"] = msg;

            return RedirectToAction(nameof(this.Index));
        }

        /// <summary>
        /// jQuery Validation 前端驗證範例
        /// </summary>
        /// <returns></returns>
        public ActionResult JQueryValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JQueryValidation(CaptchaViewModel model)
        {
            //重啟Captcha
            MvcCaptcha.ResetCaptcha("ExampleCaptcha");
            return RedirectToAction(nameof(this.JQueryValidation));
        }

        /// <summary>
        /// 相關設定範例
        /// </summary>
        /// <returns></returns>
        public ActionResult Setting()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Setting(CaptchaViewModel model)
        {
            //重啟Captcha
            MvcCaptcha.ResetCaptcha("ExampleCaptcha");
            return RedirectToAction(nameof(this.JQueryValidation));
        }
    }
}