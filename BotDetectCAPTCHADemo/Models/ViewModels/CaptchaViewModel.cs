using System.ComponentModel.DataAnnotations;

namespace BotDetectCAPTCHADemo.Models.ViewModels
{
    public class CaptchaViewModel
    {
        /// <summary>
        /// 驗證碼
        /// </summary>
        [Display(Name = "驗證碼")]
        public string CaptchaCode { get; set; }
    }
}