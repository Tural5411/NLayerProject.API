using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class CategoryWithProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Fill Name")]
        public string Name { get; set; }
        public ICollection<ProductDto>  Products { get; set; }
    }
}
