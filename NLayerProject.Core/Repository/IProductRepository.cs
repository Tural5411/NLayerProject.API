using NLayerProject.Core.Model;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repository
{
   public interface IProductRepository:IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int ProductId);
    }
}
