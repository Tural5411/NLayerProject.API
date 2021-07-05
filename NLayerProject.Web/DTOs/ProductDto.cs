using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class ProductDto
    {
        //inheritance,polimorfizm istifade etmyecem deye,class yox struckden istfd etdim,
        //suretli olsun deye(struct=value type)
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
