using AppClasseEstaticaDatas.RegrasDeNegocio;

/*
DateTime dataNascimento = new DateTime(2005, 09, 13);

DateTime dataAlvo = DateTime.Today;

TimeSpan diferenca = dataAlvo - dataNascimento;

int dias = diferenca.Days;

int meses = (int)(diferenca.Days / 30.436875);

int anos = (int)(diferenca.Days / 365.2425);

Console.WriteLine($"Dias de Vida: {dias}.");
Console.WriteLine($"Meses de Vida: {meses}.");
Console.WriteLine($"Anos de Vida: {anos}.");
*/

Console.Write("Data de Inicial [DD/MM/AAAA]...: ");
string dataInicial = Console.ReadLine()!;

Console.Write("Data Final (deixe em branco para pegar a data atual) [DD/MM/AAAA]...: ");
string dataFinal = Console.ReadLine()!;

int idade = MDatas.CalcularIdade(dataInicial, dataFinal);
int meses = MDatas.CalcularMesesDeVida(dataInicial, dataFinal);
int dias = MDatas.CalcularDiasDeVida(dataInicial, dataFinal);

Console.WriteLine($"- Idade: {idade}.");
Console.WriteLine($"- Meses: {meses}.");
Console.WriteLine($"-  Dias: {dias}.");
