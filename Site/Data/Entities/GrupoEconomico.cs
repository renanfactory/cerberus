using System;

namespace Site.Data.Entities
{
    public class GrupoEconomico : IEmpresa, IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Uf { get; set; }
        public int CodigoMunicipio { get; set; }
        public string InscricaoMunicipal { get; set; }
        public DateTime DataFundacao { get; set; }
    }
}