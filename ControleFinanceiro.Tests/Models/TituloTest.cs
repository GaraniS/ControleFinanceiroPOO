using System;
using ControleFinanceiro.Enums;
using ControleFinanceiro.Models;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleFinanceiro.Tests.Models;

[TestClass]
[TestSubject(typeof(Titulo))]
public class TituloTest
{

    [TestMethod]
    public void DeveCriarTitulo()
    {
        var titulo = new Titulo("descricao", 100m, TipoTitulo.ContaReceber, 
            new PessoaFisica("nome", "cpf"));
        
        Assert.IsNotNull(titulo);
        Assert.AreEqual(100m, titulo.Valor);
    }

    [TestMethod]
    public void NaoDeveCriarTitulo()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Titulo("descricao", -100m, TipoTitulo.ContaReceber, 
            new PessoaFisica("nome", "cpf")));
        
        Assert.AreEqual("O valor do título deve ser maior que zero.", ex.Message);
    }
}