
using MasterWeb.Application.Interfaces;
using MasterWeb.Application.ViewModels.Home;
using MasterWeb.Domain.Interfaces;
using MasterWeb.Domain.Models;

using MasterWeb.InfraData.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VueNetCore3Shop.InfraData.Context;

namespace MasterWeb.Application.Services
{
    public class CategoryServices : CommonRepository<Category>, ICategoryServices
    {

        private ICategoryRepository _categoryRepository;
        private readonly DbContext db;
        public CategoryServices(DbContext dbContext, ICategoryRepository categoryRepository) : base(dbContext)
        {
            this.db = (this.db ?? (ApplicationDbContext)db);
            _categoryRepository = categoryRepository;
        }

        public CategoryViewModel GetCategory()
        {
            return new CategoryViewModel
            {
                categories = _categoryRepository.GetCategory()
            };

        }

        public CategoryViewModel GetFristSubCategory()
        {
            return new CategoryViewModel
            {
                firstSubCategories = _categoryRepository.GetFristSubCategory()
            };
        }

        public CategoryViewModel GetSecondSubCategory()
        {
            return new CategoryViewModel
            {
                SecondSubCategories = _categoryRepository.GetSecondSubCategory()

            };
        }

    }
}

