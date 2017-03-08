using BotDetect;
using BotDetect.Web.Mvc;
using System.Drawing;

namespace BotDetectCAPTCHADemo.Helpers
{
    public static class CaptchaHelper
    {
        public static MvcCaptcha GetRegistrationCaptcha()
        {
            // create the control instance
            MvcCaptcha registrationCaptcha = new MvcCaptcha("RegistrationCaptcha")
            {
                // set up client-side processing of the Captcha code input textbox
                UserInputID = "CaptchaCode",

                #region Captcha settings

                CodeStyle = CodeStyle.Numeric,
                ReloadEnabled = false,
                SoundEnabled = false,
                CodeLength = 4,
                ImageStyle = ImageStyle.BlackOverlap,
                CustomLightColor = Color.White,
                CustomDarkColor = Color.Black,
                ImageSize = new Size(108, 45)

                #endregion Captcha settings
            };
            return registrationCaptcha;
        }
    }
}