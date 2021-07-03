using NLayerProject.Core.Repository;
using NLayerProject.Core.UnitofWork;
using NLayerProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.UnitWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public IProductRepository Product => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);

        public ICategoryRepository Category => _categoryRepository = _categoryRepository ?? new CategoryRepository(_appDbContext);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Commit() // Save Change
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _appDbContext.SaveChangesAsync();

        }
    }
}
