namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        void Update(T entity);
        void DeleteRanage(IEnumerable<T> entities);
        void Delete(T entity);
    }
}
