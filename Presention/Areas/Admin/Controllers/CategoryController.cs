using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MasterWeb.Application.Interfaces;
using MasterWeb.Application.ViewModels.Home;
using MasterWeb.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VueNetCore3Shop.InfraData.Context;

namespace MasterWeb.Mvc.Areas.Admin.Controllers
{   
    [Area("Admin")]
    //[Route("api/[controller]")]
    public class CategoryController : Controller
    {

       
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ApplicationDbContext applicationDbContext, ICategoryServices categoryServices)
        {

            _categoryServices = categoryServices;
        }
        public IActionResult Index()
        {
            CategoryViewModel model = new CategoryViewModel();
            model.categories = _categoryServices.GetAll();
            return View(model);
        }
        public IActionResult PageCateGory()
        {
            CategoryViewModel model = new CategoryViewModel();
            model.categories = _categoryServices.GetAll();
            return PartialView("~/Areas/Admin/Views/Category/Partials/P_Category.cshtml", model);
        }
        [HttpPost]
        public IActionResult InsertCatToDb(Category mycat, string CatTitle)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _categoryServices.Insert(mycat);
                    return new JsonResult("sasa");
                }
                catch (Exception e)
                {

                    throw e;
                }
                

                //CategoryViewModel model = new CategoryViewModel();
                //model.categories = _categoryServices.GetAll().OrderByDescending(p => p.CatId);
                //var json = JsonConvert.SerializeObject(model.categories.ToList());
                //return new JsonResult(json);
            }
            else
            {
                return null;
            }
            

        }
        [HttpPost]
        public IActionResult loadAjax()
        {
           
            var length = Request.Form["length"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var search = Request.Form["search[value]"].FirstOrDefault();
            string sortcolum = Request.Form["columns["+Request.Form["order[0][column]"]+"][name]"].FirstOrDefault();
            string sortdirecrion = Request.Form["order[0][dir]"].FirstOrDefault();
            int i = 0;
            
            CategoryViewModel model = new CategoryViewModel();
            int totalrecord;  

            if (!string.IsNullOrEmpty(search))
            {
                model.categories = _categoryServices.GetAll().Where(p => p.CatTitle.ToLower().Contains(search));
                totalrecord = model.categories.Count();
                model.categories=model.categories.Skip(int.Parse(start)).Take(int.Parse(length)).ToList();
              
            }
            else
            {
                model.categories = _categoryServices.GetAll().ToList();
                totalrecord = model.categories.Count();
                model.categories = model.categories.OrderByDescending(p => p.CatId).Skip(int.Parse(start)).Take(int.Parse(length)).ToList();
               
            }
            
            //model.categories=model.categories.OrderBy(sortcolum + " " + sortdirecrion).t

            List<CatTable> cat = new List<CatTable>();
            foreach (var item in model.categories)
            {

                i++;
                int row = int.Parse(start)  + i;
                CatTable table = new CatTable();
                table.row = row;
                table.onvan = item.CatTitle;
                string title = "'" + item.CatTitle + "'";
                table.opr = "<a href='javascript:void(0)' id='edit' data-catid='"+item.CatId+"' data-cattitle='"+item.CatTitle+ "' onclick='EditModel(this)'><i class='fa fa-edit' style='font-size:20px;color:darkorange'></i></a>   |   <a href = 'javascript:void(0)'  onclick= 'DeleteCate(" + item.CatId+")'><i class='fa fa-trash' style='font-size:20px;color:red'></i></a>";

                cat.Add(table);
            }

            var propertyInfo = typeof(CatTable).GetProperty(sortcolum);
            if (sortdirecrion == "asc")
            {
               cat = cat.OrderBy(x => propertyInfo.GetValue(x, null)).ToList();
            }
            else
            {
              cat = cat.OrderByDescending(x => propertyInfo.GetValue(x, null)).ToList();
            }


            //var json = JsonConvert.SerializeObject(cat);
            return Json(new { data = cat,draw=Request.Form["draw"], recordsTotal = totalrecord, recordsFiltered=totalrecord });

        }

        public IActionResult DeleteCategoryFromDb(int id)
        {
            _categoryServices.Delete(id);
            return new JsonResult("success");
        }
        public IActionResult EditCategorInDb(Category category)
            
        {
            _categoryServices.Update(category);
            return new JsonResult("success");
        }
    }

     public  class CatTable
    {
        public int row { get; set; }
        public string  onvan { get; set; }
        public string opr { get; set; }
    }
}

