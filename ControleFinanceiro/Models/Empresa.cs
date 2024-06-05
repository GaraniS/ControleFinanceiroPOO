using ControleFinanceiro.Enums;

namespace ControleFinanceiro.Models;

public class Empresa(string nome, string cnpj, decimal saldo, List<Titulo> titulos) : PessoaJuridica(nome, cnpj)
{
    public decimal Saldo
    {
        get
        {
            return Titulos.Count > 0 ? Titulos.Sum(titulo =>
                titulo.Tipo == TipoTitulo.ContaReceber ? titulo.Valor : -titulo.Valor) + saldo : saldo;
        }
    }

    private List<Titulo> Titulos { get; } = titulos;

    public Empresa(string nome, string cnpj, decimal saldo) : this(nome, cnpj, saldo, [])
    {
    }
    
    public void AdicionarTitulo(Titulo titulo)
    {
        Titulos.Add(titulo);
    }
}