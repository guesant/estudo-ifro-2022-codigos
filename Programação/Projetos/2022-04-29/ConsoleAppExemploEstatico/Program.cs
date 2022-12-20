using ConsoleAppExemploEstatico.RegrasDeNegocio;

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();
ContaCorrente conta3 = new ContaCorrente();

conta1.Valor = 1000;
conta2.Valor = 2000;

conta1.AtualizarSaldo();
//conta2.AtualizarSaldo();

Console.WriteLine($"S C1: {conta1.Saldo}");
Console.WriteLine($"S C2: {conta2.Saldo}");
Console.WriteLine($"S C3: {conta3.Saldo}"); 
Console.WriteLine("");
Console.WriteLine($"SG C1: {conta1.SaldoGeral}");
Console.WriteLine($"SG C2: {conta2.SaldoGeral}");
Console.WriteLine($"SG C3: {conta3.SaldoGeral}");