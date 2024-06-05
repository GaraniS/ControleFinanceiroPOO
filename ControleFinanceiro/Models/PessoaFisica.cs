namespace ControleFinanceiro.Models;

public class PessoaFisica(string nome, string cpf) : Pessoa(nome)
{
    public string Cpf { get; set; } = cpf;
}