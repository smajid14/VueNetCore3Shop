using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterWeb.Domain.Models
{
    public class SettingSite
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="عنوان سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} نمی تواند خالی باشد")]
        public string Title { get; set; }

        [Display(Name = "توضیحات سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} نمی تواند خالی باشد")]
        public string Description { get; set; }

        [Display(Name = "Smtp Mail")]
        public string Smpt { get; set; } //smtp.gmail.com

        [Display(Name = "ایمیل ")]
        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")]
        public string Email { get; set; } //behnamkalantar@gmail.com

        [Display(Name = "کلمه عبور ایمیل")]
        public string EmailPwd { get; set; } //pwd

        [Display(Name = "تعداد در صفحه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} نمی تواند خالی باشد")]
        public int PageNumber { get; set; }

        [Display(Name = "شماره پیامک")]
        public string SmsNumber { get; set; }

        [Display(Name = "وب سرویس پیام ")]
        public string SmsApiService { get; set; }

        [Display(Name = "کد امنیتی پیامک")]
        public string SmsSecretKey { get; set; }

        [Display(Name ="مالیات")]
        public double Tax { get; set; }


    }
}
