using CGEODP.Core.DomainObjects;

namespace ODP.Core.Data
{
    public interface IRepositoryRead<T> : IDisposable where T : class, IAggregateRoot
    {
        Task<T?> ObterId(Guid id);
        Task<IEnumerable<T>?> Listar();



    }
}
