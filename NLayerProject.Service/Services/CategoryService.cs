using NLayerProject.Core.Model;
using NLayerProject.Core.Repository;
using NLayerProject.Core.Services;
using NLayerProject.Core.UnitofWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Service.Services
{
    public class CategoryService : Servis<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsAsync(int CategoryId)
        {
            return await _unitOfWork.Category.GetWithProductsAsync(CategoryId);
        }
    }
}
