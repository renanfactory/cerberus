using Site.Data.Entities.Domains;
using Site.Data.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Site.Data.Entities
{
    public class GrupoEconomico : IEmpresa, IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Situacao { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoMunicipal { get; set; }
        public DateTime DataFundacao { get; set; }
        public virtual List<EnderecoGrupoEconomico> Enderecos { get; set; }
        public virtual List<TelefoneGrupoEconomico> Telefones { get; set; }
        public virtual List<RamoDeAtividade> RamosDeAtividade { get; set; }
    }
}