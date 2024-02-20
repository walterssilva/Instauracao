using Corregedoria.Domain.Entidades;
using Corregedoria.Domain.Interfaces;
using Corregedoria.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corregedoria.API.Controllers
{
    [ApiController]
    public class CorregedoriaController : Controller
    {
       private readonly IInstauracaoRepository _iinstauracaoRepository;
       private readonly IInstauracaoRepositoryRead _iinstauracaoRepositoryRead;


      public CorregedoriaController (IInstauracaoRepository iinstauracaoRepository, IInstauracaoRepositoryRead instauracaoRepositoryRead)
        {
            _iinstauracaoRepository = iinstauracaoRepository;
            _iinstauracaoRepositoryRead = instauracaoRepositoryRead;
        }


        [HttpGet("instauracao")]

        public async Task<IEnumerable<Instauracao>> Index()
        {
            return await _iinstauracaoRepositoryRead.Listar();
        }

        [HttpGet("instauracao/{id}")]
        public async Task<Instauracao> BuscaId(Guid id)
        {
            return await _iinstauracaoRepositoryRead.ObterId(id);
        }

        [HttpPost("instauracao-adicionar")]

        public async Task AddInstauracao(Instauracao instauracao)
        {
            await _iinstauracaoRepository.Adicionar(instauracao);
        }


        //[HttpPut("instauracao-alterar")]

        //public async Task UpInstauracao(Instauracao instauracao, Guid id)
        //{
        //    instauracao.Id = id;
        //    await _iinstauracaoRepository.Atualizar(instauracao, id);
        //}

        //[HttpDelete("instauracao-deletar")]
        //public async Task RemoveInstauracao(Guid id)
        //{
        //    await _iinstauracaoRepository.Deletar(id);
        //}


    }
}
