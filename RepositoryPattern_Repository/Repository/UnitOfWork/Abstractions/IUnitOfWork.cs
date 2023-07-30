namespace RepositoryPattern_Repository.Repository.UnitOfWork.Abstractions
{
    public interface IUnitOfWork
    {
        Task Save();
        void Dispose();
    }
}
