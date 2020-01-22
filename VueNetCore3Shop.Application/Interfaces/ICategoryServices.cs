using MasterWeb.Application.ViewModels.Home;
using MasterWeb.Domain.Interfaces;
using MasterWeb.Domain.Models;
using MasterWeb.InfraData.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterWeb.Application.Interfaces
{
    public interface ICategoryServices : ICommonRepository<Category>
    { 
        CategoryViewModel GetCategory();
        CategoryViewModel GetFristSubCategory();
        CategoryViewModel GetSecondSubCategory();
    }
}
