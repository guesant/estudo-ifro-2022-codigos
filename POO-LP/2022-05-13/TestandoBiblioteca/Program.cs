using FerramentasBiblioteca.Formatacao;
using FerramentasBiblioteca.Calculos;

Console.WriteLine("=====================================");

{
    string cpfComMascara = "111.222.333-44";
    Console.WriteLine($"Remover Máscara: {Mascaras.RemoverMascaraCPF(cpfComMascara)}");

    string cpfSemMascara = "11122233344";
    Console.WriteLine($"Aplicar Máscara: {Mascaras.AplicarMascaraCPF(cpfSemMascara)}");
}

Console.WriteLine("=====================================");

{
    string dataInicialPadrao = "13/09/2005";
    string dataFinalPadrao = "13/05/2022";

    Console.Write("Digite a Data Inicial............: ");
    string dataInicial = Console.ReadLine()!;

    if(String.IsNullOrEmpty(dataInicial))
    {
        dataInicial = dataInicialPadrao;
    }

    Console.Write("Digite a Data Final..............: ");
    string dataFinal = Console.ReadLine()!;

    if (String.IsNullOrEmpty(dataInicial))
    {
        dataFinal = dataFinalPadrao;
    }

    int idade = MDatas.CalcularIdade(dataInicial, dataFinal);
    int meses = MDatas.CalcularMesesDeVida(dataInicial, dataFinal);
    int dias = MDatas.CalcularDiasDeVida(dataInicial, dataFinal);

    Console.WriteLine($"Anos: {idade} | Meses: {meses} | Dias: {dias}");
}

Console.WriteLine("=====================================");
