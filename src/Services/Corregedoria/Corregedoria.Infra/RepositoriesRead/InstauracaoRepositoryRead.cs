using CGEODP.Core.DomainObjects;
using Corregedoria.Domain.Entidades;
using Corregedoria.Domain.Interfaces;
using Corregedoria.Infra.Data;

namespace Corregedoria.Infra.RepositoriesRead
{
    public  class InstauracaoRepositoryRead : RepositoryRead<Instauracao>, IInstauracaoRepositoryRead, IAggregateRoot
    {
        public InstauracaoRepositoryRead (CorregedoriaContext context ) : base ( context)
        {

        }
    }
}
