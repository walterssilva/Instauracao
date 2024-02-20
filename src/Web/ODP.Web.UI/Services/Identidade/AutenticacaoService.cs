﻿using Microsoft.Extensions.Options;
using ODP.Web.UI.Extensions;
using ODP.Web.UI.Models;
using ODP.Web.UI.Models.Identidade;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ODP.Web.UI.Services.Identidade
{
    public class AutenticacaoService : Service, IAutenticacaoService
    {
        private readonly HttpClient _httpClient;

        public AutenticacaoService(HttpClient httpClient,
                                   IOptions<AppSettings> settings)
        {
            httpClient.BaseAddress = new Uri(settings.Value.AutenticacaoUrl);

            _httpClient = httpClient;
        }

        public async Task<UsuarioRespostaLoginViewModel> Login(UsuarioLoginViewModel usuarioLogin)
        {
            var loginContent = ObterConteudo(usuarioLogin);

            var response = await _httpClient.PostAsync("/api/identidade/autenticar", loginContent);

            if (!TratarErrosResponse(response))
            {
                return new UsuarioRespostaLoginViewModel
                {
                    ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
                };
            }

            return await DeserializarObjetoResponse<UsuarioRespostaLoginViewModel>(response);
        }

        public async Task<UsuarioRespostaLoginViewModel> Registro(UsuarioRegistroViewModel usuarioRegistro)
        {
            var registroContent = ObterConteudo(usuarioRegistro);

            var response = await _httpClient.PostAsync("/api/identidade/nova-conta", registroContent);

            if (!TratarErrosResponse(response))
            {
                return new UsuarioRespostaLoginViewModel
                {
                    ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
                };
            }

            return await DeserializarObjetoResponse<UsuarioRespostaLoginViewModel>(response);
        }
    }
}