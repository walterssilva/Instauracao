using CGEODP.Core.DomainObjects;
using Corregedoria.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corregedoria.Domain.Entidades
{
    public class Instauracao : Entity, IAggregateRoot
    {

        public Instauracao() { }
        public Instauracao ( int ano, string cnpjcpf, string rg, ETipoOrgao orgao, ETipoProcedimento procedimento, string protocolo, string objeto,
                             string atonormativo, DateTime? datapublicacao,int? numerodioe, string atonormativodecisao, DateTime? datapublicacaodecisao,
                             int? numerodioedecisao, ETipoDecisao decisao, string infoadd)
        {
            Ano = ano;
            CNPJCPF = cnpjcpf;
            RG = rg;
            Orgao = orgao;
            Procedimento = procedimento;
            Protocolo = protocolo;
            Objeto = objeto;
            AtoNormativo = atonormativo;
            DataPublicacao = datapublicacao;
            NumeroDIOE = numerodioe;
            AtoNormativo = atonormativo;
            DataPublicacaoDecisao = datapublicacaodecisao;
            NumeroDIOEDecisao = numerodioedecisao;
            Decisao = decisao;
            InfoAdd = infoadd;


        }

        public int Ano { get;  private set; }
        public string CNPJCPF { get; private set; }
        public string RG { get; private set; }

        [Column(TypeName = "nvarchar(50)")]
        public ETipoOrgao Orgao { get; private set; }

        [Column(TypeName = "nvarchar(50)")]
        public ETipoProcedimento Procedimento { get; private set; }

        [Display(Name = "Protocolo")]
        [Column("Protocolo")]
        public string Protocolo { get; private set; }
        public string Objeto { get; private set; }

        [Display(Name = "Ato Normativo")]
        [Column("AtoNormativo")]
        public string AtoNormativo { get; private set; }

        [Display(Name = "Data Publicação")]
        [Column("DataPublicacao")]
        public DateTime? DataPublicacao { get; private set; }

        [Display(Name = "Nº DIOE")]
        [Column("NumeroDIOE")]
        public int? NumeroDIOE { get; private set; }

        [Display(Name = "Ato Normativo Decisão")]
        [Column("AtoNormativoDecisao")]
        public string AtoNormativoDecisao { get; private set; }

        [Display(Name = "Data Publicação Decisão")]
        [Column("DataPublicacaoDecisao")]
        public DateTime? DataPublicacaoDecisao { get; private set; }

        [Display(Name = "Nº DIOE Decisão")]
        [Column("NumeroDIOEDecisao")]
        public int? NumeroDIOEDecisao { get; private set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Decisão")]
        public ETipoDecisao Decisao { get; private set; }

        [Display(Name = "Info Adicionais")]
        [Column("InfoAdd")]
        public string InfoAdd { get; private set; }





    }
}
