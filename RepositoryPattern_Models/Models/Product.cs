using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
