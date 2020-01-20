using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueSPATemplate.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            // return View();
            return Redirect("~/index");
        }
    }
}