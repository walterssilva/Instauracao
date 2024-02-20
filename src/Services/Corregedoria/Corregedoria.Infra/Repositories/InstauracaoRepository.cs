using Corregedoria.Domain.Entidades;
using Corregedoria.Domain.Interfaces;
using Corregedoria.Infra.Data;

namespace Corregedoria.Infra.Repositories
{
    public  class InstauracaoRepository : Repository<Instauracao>, IInstauracaoRepository
    {
        public InstauracaoRepository(CorregedoriaContext context) : base(context)
        {


        }
    }
}
