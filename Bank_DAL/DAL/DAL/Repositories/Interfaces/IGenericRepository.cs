using DAL.Repositories.Interfaces.Opereations;

namespace DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> : ICreate<T>, IRead<T>, IReadAll<T>, IUpdate<T>, IDelete<T> where T : class
    {
    }
}
