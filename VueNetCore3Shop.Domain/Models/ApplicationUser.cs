using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MasterWeb.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings=false,ErrorMessage = "{0}خود را وارد نمایید ")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        public string LastName { get; set; }
        [Display(Name = "استان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        public string Province { get; set; }
        [Display(Name = "شهر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        public string City { get; set; }
        [Display(Name = "موبایل")]
        [DataType(DataType.PhoneNumber)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        public string Mobile { get; set; }
        [Display(Name = "آدرس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Display(Name = "کد پستی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        [DataType(DataType.PostalCode)]
        public string  PostalCode { get; set; }


    }
}
