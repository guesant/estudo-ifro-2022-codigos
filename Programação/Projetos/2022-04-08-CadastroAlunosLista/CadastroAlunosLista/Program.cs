using CadastroAlunosLista.RegrasDeNegocio;

int opc;

string resposta;

List<Aluno> listaAlunos = new List<Aluno>();

void MostrarAluno(Aluno aluno)
{
    Console.WriteLine($"< Nome: {aluno.Nome}");
    Console.WriteLine($"< Nota 1: {aluno.Nota1}");
    Console.WriteLine($"< Nota 2: {aluno.Nota2}");
    Console.WriteLine($"< Média: {aluno.Media}");
    Console.WriteLine($"< Situação: {aluno.Situacao()}");
}

void MostrarErro(string msg)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(msg);
    Console.ForegroundColor = ConsoleColor.White;
}

do
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("======[ Registro de Alunos ]======");
    Console.WriteLine("==================================");

    Console.WriteLine("");

    Console.WriteLine("[1] - Cadastrar");
    Console.WriteLine("[2] - Consultar");
    Console.WriteLine("[3] - Listar Registros");
    Console.WriteLine("[4] - Fechar Programa");

    Console.WriteLine("");

    Console.Write("> Escolha a sua opção: ");

    opc = Convert.ToInt32(Console.ReadLine());

    switch (opc)
    {
        case 1:
            {

                while (true)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Iniciando o registro de um aluno:");

                    var aluno = new Aluno();

                    Console.Write("-> Nome: ");
                    aluno.Nome = Console.ReadLine()!;

                    Console.Write("-> Nota 1: ");
                    aluno.Nota1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("-> Nota 2: ");
                    aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

                    aluno.CalcularMedia();

                    listaAlunos.Add(aluno);

                    Console.WriteLine("Aluno cadastrado com sucesso!");

                    Console.WriteLine("-----------------------------------");

                    Console.Write("Deseja cadastrar mais algum aluno? [s/N]: ");

                    resposta = Console.ReadLine()!.ToLower();

                    if (resposta != "s")
                    {
                        break;
                    }
                }

                break;
            }
        case 2:
            {

                if (listaAlunos.Count == 0)
                {
                    MostrarErro("Nenhum aluno foi registrado ainda!");
                    break;
                }

                while (true)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Iniciando a consulta de um aluno:");


                    Console.Write($"> Posição (entre 0 e {listaAlunos.Count - 1}): ");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    if (pos >= 0 && pos < listaAlunos.Count)
                    {
                        
                        Console.WriteLine("----------------------");
                        
                        var aluno = listaAlunos[pos];
                        MostrarAluno(aluno);
                        
                        Console.WriteLine("----------------------");

                    }
                    else
                    {
                        MostrarErro("Posição Inválida!");
                    }

                    Console.WriteLine("-----------------------------------");

                    Console.Write("Deseja consultar mais algum aluno? [s/N]: ");

                    resposta = Console.ReadLine()!.ToLower();

                    if (resposta != "s")
                    {
                        break;
                    }
                }

                break;
            }
        case 3:
            {
                Console.WriteLine($"Listando os {listaAlunos.Count} alunos:");

                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    Console.WriteLine($"-----------[{i}]-----------");
                    var aluno = listaAlunos[i];
                    MostrarAluno(aluno);
                }

                Console.WriteLine($"-------------------------");

                break;
            }
        case 4:
            {
                Console.WriteLine("Saindo...");
                break;
            }
        default:
            {
                MostrarErro("Opção Inválida!");
                break;
            }
    }

    Console.Write("Pressione qualquer tecla para continuar...");
    Console.ReadKey();

} while (opc != 4);

Console.WriteLine("Fim.");