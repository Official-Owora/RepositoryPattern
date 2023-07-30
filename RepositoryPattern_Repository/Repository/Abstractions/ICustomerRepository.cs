using RepositoryPattern_Models.Models;

namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomer(int id);
        Task<Customer> GetCustomerAsync(int id);
        //IQueryable<Customer> GetAllCustomers();
    }
}
