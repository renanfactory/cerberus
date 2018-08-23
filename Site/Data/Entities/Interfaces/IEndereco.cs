namespace Site.Data.Entities.Interfaces
{
    public interface IEndereco
    {
        string Cep { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        string Complemento { get; set; }
        string UF { get; set; }
        int Cidade { get; set; }
    }
}
