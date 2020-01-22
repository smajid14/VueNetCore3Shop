using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterWeb.Domain.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public int ProductId_FK { get; set; }
        public string UserId_FK { get; set; }
        [Display(Name ="نام و نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        public string FullName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}خود را وارد نمایید ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "{0} را صحیح وارد نمایید")]
        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$",ErrorMessage = "{0} را صحیح وارد نمایید")]
        public string Email { get; set; }
        [Display(Name = "عنوان دیدگاه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد نمایید ")]
        public string Title { get; set; }
        [Display(Name = "متن دیدگاه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد نمایید ")]
        public string Text { get; set; }

        public string IP { get; set; }

        public DateTime DateComment { get; set; }

        public bool ConfirmComment { get; set; }


        [ForeignKey(nameof(UserId_FK))]
        public virtual ApplicationUser Tbl_User { get; set; }

        [ForeignKey(nameof(ProductId_FK))]
        public virtual Products Tbl_Products { get; set; }

    }
}
