using CGEODP.Core.DomainObjects;
using Corregedoria.Infra.Data;
using Microsoft.EntityFrameworkCore;
using ODP.Core.Data;

namespace Corregedoria.Infra.RepositoriesRead
{
    public class RepositoryRead<T> : IRepositoryRead<T> where T : class, IAggregateRoot
    {
        protected readonly CorregedoriaContext _context;

        public RepositoryRead(CorregedoriaContext context)
        {
            _context = context;
        }

        public virtual async Task<T?> ObterId(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>?> Listar()
        {
            IQueryable<T> query = _context.Set<T>();
            return await query.ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
