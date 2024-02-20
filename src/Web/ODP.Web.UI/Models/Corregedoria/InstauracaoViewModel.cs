using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Corregedoria.Domain.Enum;

namespace ODP.Web.UI.Models.Corregedoria
{
    public class InstauracaoViewModel
    {
        public Guid Id { get; set; }
        public int Ano { get; private set; }
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
