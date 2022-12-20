using ConsoleAppExemploClasseEstatica.RegrasDeNegocio;

Console.WriteLine("=========================================");

{
    string texto = "FICA EM CASA!";

    Console.WriteLine($"Length: {texto.Length}.");

    Console.WriteLine($"Substring (2, 4): {texto.Substring(2, 4)}");

    Console.WriteLine($"Substring (5, 7): {texto.Substring(5, 7)}");
}

Console.WriteLine("=========================================");

{
    Console.Write("Telefone: ");
    string num = Console.ReadLine()!; // xxyyyyyzzzz

    num = FormatarNumTelefone.FormatarNumero(num); // (xx)-yyyyy-zzzz

    Console.WriteLine($"- Número Mascarado: {num}");

}

Console.WriteLine("=========================================");

{
    Console.Write("CPF: ");
    string cpf = Console.ReadLine()!; // xxxyyyzzzvv

    cpf = FormarPFePJ.FormatarCPF(cpf); // xxx.yyy.zzz-vv

    Console.WriteLine($"- CPF Mascarado: {cpf}");

}

Console.WriteLine("=========================================");

{
    Console.Write("CNPJ: ");
    string cnpj = Console.ReadLine()!; // aabbbcccddddee

    cnpj = FormarPFePJ.FormatarCNPJ(cnpj); // aa.bbb.ccc/dddd-ee

    Console.WriteLine($"- CNPJ Mascarado: {cnpj}");

}

Console.WriteLine("=========================================");
