using Maxishop.Application.Common;
using Maxishop.Application.Services;
using Maxishop.Application.Services.Interface;
using Maxishop.Domain.Contracts;
using Maxishop.Infrastruture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IBrandService,BrandService>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IPaginationService<,>), typeof(PaginationService<,>));
            services.AddScoped<IAuthService, AuthService>();
            

            return services;
        }
    }
}
