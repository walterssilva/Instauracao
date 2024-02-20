using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using ODP.Web.UI.Services.Corregedoria;

namespace ODP.Web.UI.Controllers
{
    public class CorregedoriaController : MainController
    {
        private readonly IInstauracaoService _instauracaoService;

        public CorregedoriaController(IInstauracaoService instauracaoService)
        {
            _instauracaoService = instauracaoService;
        }

        [HttpGet]
        [Route("")]
        [Route("instauracao")]
        public async Task<IActionResult> Index()
        {
            var instauracaoes = await _instauracaoService.ObterTodos();

            return View(instauracaoes);
        }

        [HttpGet]
        [Route("instauracao-detalhe/{id}")]
        public async Task<IActionResult> Detalhe(Guid id)
        {
            var instauracao = await _instauracaoService.ObterPorId(id);

            return View(instauracao);
        }
    }
}
