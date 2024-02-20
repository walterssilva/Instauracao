using ODP.Web.UI.Models.Identidade;
using System.Threading.Tasks;

namespace ODP.Web.UI.Services.Identidade
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLoginViewModel> Login(UsuarioLoginViewModel usuarioLogin);

        Task<UsuarioRespostaLoginViewModel> Registro(UsuarioRegistroViewModel usuarioRegistro);
    }
}