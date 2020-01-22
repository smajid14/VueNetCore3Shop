using MasterWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterWeb.Application.ViewModels.Home
{
    public class CategoryViewModel
    {
        public IEnumerable<Category> categories { get; set; }
        public Category cat { get; set; }
        public IEnumerable<FirstSubCategory> firstSubCategories { get; set; }
        public IEnumerable<SecondSubCategory> SecondSubCategories { get; set; }
    }

}
