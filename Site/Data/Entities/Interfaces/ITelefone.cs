using Site.Data.Entities.Domains;

namespace Site.Data.Entities.Interfaces
{
    public interface ITelefone
    {
        string CodigoPais { get; set; }
        string CodigoRegiao { get; set; }
        string Numero { get; set; }
        string Ramal { get; set; }
        TipoTelefone TipoTelefone { get; set; }
    }
}
