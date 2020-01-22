﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasterWeb.Domain.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Display(Name = "عنوان دسترسی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد نمایید ")]
        public string RoleTitle { get; set; }

        [Display(Name = "نام دسترسی")]
         [Required(AllowEmptyStrings = false, ErrorMessage = "{0} را وارد نمایید ")]
        public string RoleName { get; set; }


        public virtual ICollection<UserAccess> Tbl_UserAccess { get; set; }
    }
}
