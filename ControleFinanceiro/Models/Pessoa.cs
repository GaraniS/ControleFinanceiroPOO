namespace ControleFinanceiro.Models;

public abstract class Pessoa(string nome)
{
    public string Nome { get; set; } = nome;
}