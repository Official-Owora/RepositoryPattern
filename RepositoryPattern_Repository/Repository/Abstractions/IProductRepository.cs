using RepositoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<Product> GetProductByIdAsync(int id);
        public Task<IEnumerable<Product>> GetAllProductByCustomerIdAsync(int id);
    }
}
