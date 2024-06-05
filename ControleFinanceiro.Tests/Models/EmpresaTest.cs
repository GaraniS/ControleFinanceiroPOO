using ControleFinanceiro.Enums;
using ControleFinanceiro.Models;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleFinanceiro.Tests.Models;

[TestClass]
[TestSubject(typeof(Empresa))]
public class EmpresaTest
{

    [TestMethod]
    public void DeveCalcularSaldoEmpresa()
    {
        var titulo = new Titulo(null, 100, TipoTitulo.ContaReceber, 
            new PessoaFisica("João", "12345678900"));
        var empresa = new Empresa("Empresa Teste", "12345678901234", 1000, [titulo]);
        
        Assert.AreEqual(1100, empresa.Saldo);
    }
    
    [TestMethod]
    public void DeveAdicionarTitulo()
    {
        var titulo = new Titulo(null, 100, TipoTitulo.ContaReceber, 
            new PessoaFisica("João", "12345678900"));
        var titulo2 = new Titulo(null, 5000, TipoTitulo.ContaPagar, 
            new PessoaFisica("Investidor X", "12345678901"));
        var empresa = new Empresa("Empresa Teste", "12345678901234", 1000, [titulo]);
        
        empresa.AdicionarTitulo(titulo2);
        
        Assert.AreEqual(-3900, empresa.Saldo);
    }
}