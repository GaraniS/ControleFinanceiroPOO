using ControleFinanceiro.Enums;
using ControleFinanceiro.Models;

try {
    var cliente1 = new PessoaFisica("João", "123.456.789-00");
    var cliente2 = new PessoaJuridica("Investidor X", "12.345.678/0001-99");

    var titulo1 = new Titulo("Conta de Luz", 1000m, TipoTitulo.ContaReceber, cliente1);
    var titulo2 = new Titulo("Dividendos", 500m, TipoTitulo.ContaPagar, cliente2);
    var titulo3 = new Titulo("Nova conta", 500m, TipoTitulo.ContaPagar, cliente2);

    var titulos = new List<Titulo> { titulo1, titulo2 };

    var empresa = new Empresa("Empresa XYZ", "12.345.678/0001-99", 5000m, titulos);
    var empresa2 = new Empresa("Empresa ABC", "98.765.432/0001-11", 10000m);
    
    empresa.AdicionarTitulo(titulo3);

    Console.WriteLine($"Saldo da empresa: {empresa.Saldo:C}");
    Console.WriteLine($"Saldo da empresa2: {empresa2.Saldo:C}");
} catch (Exception e) {
    Console.WriteLine($"Erro: {e.Message}");
}
