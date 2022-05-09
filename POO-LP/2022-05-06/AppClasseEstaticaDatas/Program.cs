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

Console.Write("Data de Nascimento: (DD/MM/AAAA)...: ");
string dataNasc = Console.ReadLine()!;

Console.Write("Data Alvo (deixe em branco para pegar a data atual): (DD/MM/AAAA)...: ");
string dataAlvo = Console.ReadLine()!;

int idade = MDatas.CalcularIdade(dataNasc, dataAlvo);
int meses = MDatas.CalcularMesesDeVida(dataNasc, dataAlvo);
int dias = MDatas.CalcularDiasDeVida(dataNasc, dataAlvo);

Console.WriteLine($"- Idade: {idade}.");
Console.WriteLine($"- Meses: {meses}.");
Console.WriteLine($"-  Dias: {dias}.");