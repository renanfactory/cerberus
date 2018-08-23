using System;

namespace Site.Data.Entities.Interfaces
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
        /// Nome fantasia da Empresa
        /// </summary>
        string NomeFantasia { get; set; }

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