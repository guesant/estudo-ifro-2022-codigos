using ConsoleAppLista.RegrasDeNegocio;

/*
const uint TOTAL_PESSOAS = 100;
uint GerarPosicaoAleatoria()
{
    var rand = new Random();
    
    uint numero = (uint)Math.Floor(rand.NextDouble() * TOTAL_PESSOAS);

    Console.WriteLine($"Posição aleatória: {numero}.");

    return numero;
}
*/

/*
void MostrarPessoa(Pessoa pessoa)
{
    Console.WriteLine($"- Nome: {pessoa.Nome}.");
    Console.WriteLine($"- Idade: {pessoa.Idade}.");
    Console.WriteLine($"- Salário: {string.Format("{0:C}", pessoa.Salario)}.");
}
*/

var pessoas = new List<Pessoa>();

var objPessoa = new Pessoa();

objPessoa.Nome = "Gabriel";
objPessoa.Idade = 16;
objPessoa.Salario = 0;
pessoas.Add(objPessoa);

Console.WriteLine(pessoas[0].Nome);

/*
for(int i = 0; i < pessoas.Length; i++)
{
    var pessoa = pessoas[i] = new Pessoa();

    Console.Write("Nome: ");
    pessoa.Nome = Console.ReadLine();

    Console.Write("Idade: ");
    pessoa.Idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Salário: ");
    pessoa.Salario = Convert.ToDouble(Console.ReadLine());


    Console.Write("Deseja continuar? [sim/nao]: ");

    if(Console.ReadLine()!.ToLower() == "nao")
    {
        break;
    }
}
*/