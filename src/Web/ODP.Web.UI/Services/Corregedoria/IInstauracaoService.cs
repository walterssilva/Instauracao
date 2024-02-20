using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ODP.Web.UI.Models.Corregedoria;

namespace ODP.Web.UI.Services.Corregedoria
{
    public interface IInstauracaoService
    {
        Task<IEnumerable<InstauracaoViewModel>> ObterTodos();
        Task<InstauracaoViewModel> ObterPorId(Guid id);
    }
}
