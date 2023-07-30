using RepositoryPattern_Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern_Models.Models
{
    public class Product : BaseEntity
    {
        public int CustomerId { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public Status ProductStatus { get; set; }
        public ProductCategories ProductCategory { get; set; }
        public string ProductCategoryDesc { set { ProductCategory.ToString(); } }
    }
}
