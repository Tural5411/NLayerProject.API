using NLayerProject.Core.Model;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductsAsync(int CategoryId);
    }
}
