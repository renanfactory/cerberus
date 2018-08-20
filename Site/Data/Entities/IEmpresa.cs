using System;

namespace Site.Data.Entities
{
    public interface IEmpresa
    {
         /// <summary>
        /// CNPJ da Empresa
        /// </summary>
        string CNPJ { get; set; }

        /// <summary>
        /// Nome da Empresa
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Código da unidade Federativa da Empresa
        /// </summary>
        int CodigoMunicipio { get; set; }

        /// <summary>
        /// Inscrição municipal da empresa
        /// </summary>
        string InscricaoMunicipal { get; set; }

        /// <summary>
        /// Data de fundação da empresa
        /// </summary>
        DateTime DataFundacao {get;set;}
    }
}