using Microsoft.Extensions.Options;
using ODP.Web.UI.Extensions;
using ODP.Web.UI.Models.Corregedoria;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ODP.Web.UI.Services.Corregedoria
{
    public class InstauracaoService : Service, IInstauracaoService
    {
        private readonly HttpClient _httpClient;

        public InstauracaoService(HttpClient httpClient,
            IOptions<AppSettings> settings)
        {
            httpClient.BaseAddress = new Uri(settings.Value.CorregedoriaUrl);

            _httpClient = httpClient;
        }

        public async Task<InstauracaoViewModel> ObterPorId(Guid id)
        {
            var response = await _httpClient.GetAsync($"/corregedoria//{id}");

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<InstauracaoViewModel>(response);
        }

        public async  Task<IEnumerable<InstauracaoViewModel>> ObterTodos()
        {
            var response = await _httpClient.GetAsync("/corregedoria/produtos/");

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<IEnumerable<InstauracaoViewModel>>(response);
        }
    }
}
