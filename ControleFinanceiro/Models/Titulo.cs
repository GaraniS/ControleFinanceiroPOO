using ControleFinanceiro.Enums;

namespace ControleFinanceiro.Models;

public class Titulo
{
    public Titulo(string? descricao, decimal valor, TipoTitulo tipo, Pessoa pessoaRelacionada)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do título deve ser maior que zero.");
        }
        Valor = valor;
        Descricao = descricao;
        Tipo = tipo;
        PessoaRelacionada = pessoaRelacionada;
    }

    public string? Descricao { get; set; }
    public decimal Valor { get; }

    public TipoTitulo Tipo { get; set; }
    public Pessoa PessoaRelacionada { get; set; }
}