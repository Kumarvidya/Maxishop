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
   public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext):base(dbContext) { 
        }
        public async Task UpdateAsync(Category category)
        {
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
            
        }
    }
}
