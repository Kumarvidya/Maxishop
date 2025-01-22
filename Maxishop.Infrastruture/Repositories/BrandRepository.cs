using Maxishop.Domain.Contracts;
using Maxishop.Domain.Models;
using Maxishop.Infrastruture.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Infrastruture.Repositories
{
   public class BrandRepository:GenericRepository<Brand>,IBrandRepository
    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task UpdateAsync(Brand brand)
        {
            _dbContext.Update(brand);
            await _dbContext.SaveChangesAsync();

        }
    }
}

