using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using RepositoryPattern_Repository.Repository.Implementations;
using RepositoryPattern_Repository.Repository.UnitOfWork.Abstractions;

namespace RepositoryPattern_Repository.Repository.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IProductRepository Products => _productRepository ??= new ProductRepository(_appDbContext);
        public ICustomerRepository Customers => _customerRepository ??= new CustomerRepository(_appDbContext);
        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _appDbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
