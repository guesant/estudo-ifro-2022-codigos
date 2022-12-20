using FerramentasBiblioteca.Formatacao;
using FerramentasBiblioteca.Calculos;
using FerramentasBiblioteca.Validacao;

void ContasBancariasValidarContaBB()
{
    Console.WriteLine(ContasBancarias.ValidarContaBB("", "011743697"));
}

void MascarasCPF()
{
    string cpfComMascara = "111.222.333-44";
    Console.WriteLine($"Remover Máscara: {Mascaras.RemoverMascaraCPF(cpfComMascara)}");

    string cpfSemMascara = "11122233344";
    Console.WriteLine($"Aplicar Máscara: {Mascaras.AplicarMascaraCPF(cpfSemMascara)}");
}

void MascaraTelefone()
{
    string telefoneComMascara = "(00)-98888-7777";
    Console.WriteLine($"Remover Máscara: {Mascaras.RemoverMascaraTelefone(telefoneComMascara)}");

    string telefoneSemMascara = "00988887777";
    Console.WriteLine($"Aplicar Máscara: {Mascaras.AplicarMascaraTelefone(telefoneSemMascara)}");
}

void MDatasDiff()
{
    string dataInicialPadrao = "13/09/2005";
    string dataFinalPadrao = "13/05/2022";

    Console.Write("Digite a Data Inicial............: ");
    string dataInicial = Console.ReadLine()!;

    if (String.IsNullOrEmpty(dataInicial))
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

while(true)
{

    Console.WriteLine("===========================================");
    Console.WriteLine("[1] Contas Bancárias / Validar Conta BB");
    Console.WriteLine("[2] Mascaras / CPF");
    Console.WriteLine("[3] Mascaras / Telefone");
    Console.WriteLine("[4] MDatas / Diff");
    Console.WriteLine("[0] Sair");
    Console.WriteLine("===========================================");
    
    Console.Write(">> ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao == 0)
    {
        break;
    }

    switch (opcao)
    {
        case 1:
        {
            ContasBancariasValidarContaBB();
            break;
        }

        case 2:
        {
            MascarasCPF();
            break;
        }
        case 3:
        {
            MascaraTelefone();
            break;
        }
        case 4:
        {
            MDatasDiff();
            break;
        }
        default:
        {
            Console.Error.WriteLine("Opção Inválida!");
            break;
        }
    }

    
    Console.ReadKey();
    Console.Clear();
}