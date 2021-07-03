using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Model;
using NLayerProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    // Esas repositoryden ferqli metodlar yazmaq istesem bura yaz
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int ProductId)
        {
            var product = appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == ProductId);
            return await product;
        }
    }
}
