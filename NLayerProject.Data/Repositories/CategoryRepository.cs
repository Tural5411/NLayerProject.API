using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Model;
using NLayerProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private  AppDbContext _appDbContext { get => _context as AppDbContext; }
        //Servis yazdigim ucun ucun asagdaki DbContexti AppDbContext ile evez etdim
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductsAsync(int CategoryId)
        {
            var category = _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == CategoryId);
            return await category;
        }
    }
}
