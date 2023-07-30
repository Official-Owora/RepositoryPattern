namespace RepositoryPattern_Models.Models
{
    public class Customer : BaseEntity
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}
