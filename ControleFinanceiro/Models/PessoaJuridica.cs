namespace ControleFinanceiro.Models;

public class PessoaJuridica(string nome, string cnpj) : Pessoa(nome)
{
    public string Cnpj { get; set; } = cnpj;
}