using MasterWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterWeb.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategory();
        IEnumerable<FirstSubCategory> GetFristSubCategory();
        IEnumerable<SecondSubCategory> GetSecondSubCategory();
    }
}

