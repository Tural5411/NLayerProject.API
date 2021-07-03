using NLayerProject.Core.Model;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsAsync(int CategoryId);

    }
}
