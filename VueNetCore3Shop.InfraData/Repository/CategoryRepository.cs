using MasterWeb.Domain.Interfaces;
using MasterWeb.Domain.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VueNetCore3Shop.InfraData.Context;

namespace MasterWeb.InfraData.Repository
{
    public class CategoryRepository :CommonRepository<Category>, ICategoryRepository, IDisposable
    {
        ApplicationDbContext _applicationDbContext;
        private readonly DbContext db;
        public CategoryRepository(DbContext dbContext,ApplicationDbContext applicationDbContext):base(dbContext)
        {

            this.db = (this.db ?? (ApplicationDbContext)db);
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Category> GetCategory()
        {
            try
            {
                return _applicationDbContext.Tbl_Category;
                   
            }
            catch
            {

                throw;
            }

        }
        public IEnumerable<FirstSubCategory> GetFristSubCategory()
        {
            try
            {
                 return _applicationDbContext.Tbl_FirstSubCategory;
            }
            catch
            {

                throw;
            }
        }
        public IEnumerable<SecondSubCategory> GetSecondSubCategory()
        {
            try
            {
                return _applicationDbContext.Tbl_SecondSubCategory;
            }
            catch
            {

                throw;
            }
        }

        ~CategoryRepository()
        {
            Dispose();
        }     

        
    }
}
