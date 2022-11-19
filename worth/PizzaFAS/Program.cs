/*
Equipe Alset - 2022

- Gabriel R. Antunes
- Vitor Melo
- Pedro Henrique

Data: 2022-06-18 09:47
*/

// INÍCIO CONSTANTES
const int QNT_FATIAS_POR_PESSOA = 3;
const double QNT_REFRI_POR_PESSOA = 0.5;

const double QNT_FATIAS_PIZZA = 12;
const double QNT_LITROS_REFRI = 2;

const double VALOR_PIZZA = 100;
const double VALOR_REFRI = 12;

const double SUBSIDIO_PROF = 0.5;
// FIM CONSTANTES

Console.Write("Digite a quantidade de participantes: ");
int quantidadeParticipantes = Convert.ToInt32(Console.ReadLine());

MostrarInformacoes(quantidadeParticipantes);

static void MostrarInformacoes(int quantidadeParticipantes)
{
    int totFatias, totPizzas, totGarrafas;
    double totLitros, totValor, totValorPizza, totValorRefri, totSubsidiado, totSubsidiadoRestante;

    totFatias = quantidadeParticipantes * QNT_FATIAS_POR_PESSOA;
    totPizzas = Convert.ToInt32(Math.Ceiling(totFatias / QNT_FATIAS_PIZZA));

    totLitros = quantidadeParticipantes * QNT_REFRI_POR_PESSOA;
    totGarrafas = Convert.ToInt32(Math.Ceiling(totLitros / QNT_LITROS_REFRI));

    totValorPizza = VALOR_PIZZA * totPizzas;
    totValorRefri = VALOR_REFRI * totGarrafas;

    totValor = totValorPizza + totValorRefri;

    //

    totSubsidiado = totValor * SUBSIDIO_PROF;
    totSubsidiadoRestante = totValor - totSubsidiado;

    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine($"Total de fatias: {totFatias}.");
    Console.WriteLine($"Total de pizzas: {totPizzas}.");
    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine($"Total de litros........: {totLitros}L.");
    Console.WriteLine($"Total de garrafas de 2L: {totGarrafas}.");
    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine($"R$ em pizzas: {totValorPizza.ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"R$ em refri.: {totValorRefri.ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"R$ Total....: {totValor.ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"----------------------------------------------------------");
    Console.WriteLine($"R$ subsidiado pelo professor: {totSubsidiado.ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"R$ que os alunos irão rachar: {totSubsidiadoRestante.ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"R$ por aluno................: {(totSubsidiadoRestante / quantidadeParticipantes).ToString("C").PadLeft(11, ' ')}.");
    Console.WriteLine($"----------------------------------------------------------");
}