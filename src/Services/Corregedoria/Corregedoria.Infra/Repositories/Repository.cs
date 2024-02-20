using CGEODP.Core.Data;
using CGEODP.Core.DomainObjects;
using Corregedoria.Infra.Data;

namespace Corregedoria.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected readonly CorregedoriaContext _context;

        public Repository(CorregedoriaContext context)
        {
            _context = context;
        }

        public async Task Atualizar(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Adicionar(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
