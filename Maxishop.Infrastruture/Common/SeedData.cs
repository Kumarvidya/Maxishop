using Maxishop.Domain.Models;
using Maxishop.Infrastruture.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Infrastruture.Common
{
    public class SeedData
    {
        public static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            using var scope=serviceProvider.CreateScope();
            var roleManager=scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new List<IdentityRole>
            {
                new IdentityRole{Name="ADMIN",NormalizedName="ADMIN"},
                new IdentityRole{Name="CUSTOMER",NormalizedName="CUSTOMER"}
            };
            foreach (var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role.Name))
                {
                    await roleManager.CreateAsync(role);
                }
            }
}
        public static async Task SeedDataAsync(ApplicationDbContext _dbcontext)
        {
            if (!_dbcontext.Brand.Any())
            {
                await _dbcontext.AddRangeAsync(
                    new Brand
                    {
                        Name = "Apple",
                        EstablishedYear = 1980
                    },
                        new Brand
                        {
                            Name = "Samsung",
                            EstablishedYear = 1980
                        },
                            new Brand
                            {
                                Name = "Sony",
                                EstablishedYear = 1980
                            },
                                new Brand
                                {
                                    Name = "Apache",
                                    EstablishedYear = 1980
                                },
                                    new Brand
                                    {
                                        Name = "Lenovo",
                                        EstablishedYear = 1980
                                    },
                                        new Brand
                                        {
                                            Name = "Acer",
                                            EstablishedYear = 1980
                                        },
                                            new Brand
                                            {
                                                Name = "Hp",
                                                EstablishedYear = 1980
                                              });
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}
