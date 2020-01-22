using MasterWeb.Application.Interfaces;
using MasterWeb.Application.Services;
using MasterWeb.Domain.Interfaces;
using MasterWeb.InfraData.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VueNetCore3Shop.InfraData.Context;

namespace MasterWeb.InfraIOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ICategoryServices, CategoryServices>();
            //Infra  Data
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<DbContext, ApplicationDbContext>();
        }
    }
}
