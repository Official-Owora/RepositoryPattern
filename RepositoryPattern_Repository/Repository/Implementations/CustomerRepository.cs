using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Models.Models;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Customer> _customers;

        public CustomerRepository(AppDbContext appDbContext) : base(appDbContext) 
        {
            _appDbContext = appDbContext;
            _customers = _appDbContext.Set<Customer>();
        }
        public Customer GetCustomer(int id)
        {
            Customer customer = _customers.Find(id);
            return customer;
        }
        public async Task<Customer> GetCustomerAsync(int id)
        {
            Customer customer = await _customers.FindAsync(id);
            return customer;
        }
        /*public IQueryable<Customer> GetAllCustomers()
        {
            IQueryable<Customer> customers = _customers.Include(x => x.Products);
            return customers;
        }*/
    }
}
