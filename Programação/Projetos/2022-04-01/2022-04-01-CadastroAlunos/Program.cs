using _2022_04_01_CadastroAlunos.RegrasDeNegocio;

void LogErro(string msg)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(msg);
    Console.ForegroundColor = ConsoleColor.White;
}

var alunosLista = new Aluno[50];

int totAlunosRegistrados = 0;

for (int i = 0; i < alunosLista.Length; i++)
{
    Console.WriteLine("------------------------------------");
    
    Console.WriteLine($"Iniciando o registro do {i+1}º aluno.");

    var aluno = new Aluno();

    Console.Write("Digite o nome do aluno: ");
    aluno.Nome = Console.ReadLine()!;

    Console.Write("Digite a 1ª nota do aluno: ");
    aluno.Nota1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a 2ª nota do aluno: ");
    aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

    aluno.CalcularMedia();

    alunosLista[i] = aluno;
    
    Console.WriteLine($"Concluindo o registro do {i+1}º aluno.");
    
    Console.WriteLine("------------------------------------");
    
    totAlunosRegistrados++;

    if (i != alunosLista.Length - 1) { 
        Console.Write("Deseja inserir o próximo registro? [S/n]: ");
        
        string resposta = Console.ReadLine()!.ToLower();

        if(resposta == "n")
        {
            break;
        }
    }
}

while(true)
{
    Console.WriteLine("------------------------------------");
    
    Console.Write($"Digite a posição do número que você deseja consultar: ");
    int pos = Convert.ToInt32(Console.ReadLine());

    if(pos >= 0 && pos < totAlunosRegistrados)
    {
        var aluno = alunosLista[pos];

        if(aluno != null)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"< Nome: {aluno.Nome}.");
            Console.WriteLine($"< Média: {aluno.Media}.");
            Console.WriteLine($"< Situação: {aluno.Situacao()}.");
            Console.WriteLine("-----------------------");
        }
        else
        {
            LogErro("* Não foi possível encontrar o aluno solicitado.");
        }
    } 
    else
    {
        LogErro("POSIÇÃO INVÁLIDA!");
    }

    Console.Write("Deseja consultar o próximo aluno? [S/n]: ");

    string resposta = Console.ReadLine()!.ToLower();

    if (resposta == "n")
    {
        break;
    }
}