namespace Site.Services
{
    public interface IValidacoes
    {
        bool IsValidCPF(string cpf);
        bool isValidCNPJ(string cnpj);
        bool isValidRG(string rg);
        bool isValidPis(string pis);
    }
}
