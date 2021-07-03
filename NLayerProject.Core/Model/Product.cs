namespace NLayerProject.Core.Model
{
   public class Product:Base
    {
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Barcode { get; set; }
        public virtual Category Category { get; set; }
    }
}
