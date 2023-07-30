using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Models.Models;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Product> _products;

        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _products = _appDbContext.Set<Product>();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            Product product = await _products.FindAsync(id);
            return product;
        }
        public async Task<IEnumerable<Product>> GetAllProductByCustomerIdAsync(int id)
        {
            IEnumerable<Product> product = await _products.Where(x => x.CustomerId == id).ToListAsync();
            return product;
        }
    }
}
