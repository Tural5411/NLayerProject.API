using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NLayerProject.Core.Model
{
    public class Category:Base
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public ICollection<Product> Products { get; set; }
    }
}
