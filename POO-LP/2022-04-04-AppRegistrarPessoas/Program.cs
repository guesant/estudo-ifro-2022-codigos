using AppRegistrarPessoas.RegrasDeNegocio;

int opc;

List<Pessoa> listaPessoas = new List<Pessoa>();

void MostrarPessoa(Pessoa pessoa)
{
    Console.WriteLine($"< Nome: {pessoa.Nome}");
    Console.WriteLine($"< Idade: {pessoa.Idade}");
    Console.WriteLine($"< Salário: {pessoa.Salario}");
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
    Console.WriteLine("=====[ Registro de Pessoas ]======");
    Console.WriteLine("==================================");

    Console.WriteLine("");

    Console.WriteLine("[1] - Cadastrar");
    Console.WriteLine("[2] - Consultar");
    Console.WriteLine("[3] - Listar Registros");
    Console.WriteLine("[4] - Fechar Programa");

    Console.WriteLine("");

    Console.Write("> Escolha a sua opção: ");

    opc = Convert.ToInt32(Console.ReadLine());

    //if(opc == 4)
    //{
    //    break;
    //}

    switch (opc)
    {
        case 1:
            {
                
                while(true)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Iniciando o registro de uma pessoa:");
                    
                    var pessoa = new Pessoa();

                    Console.Write("-> Nome: ");
                    pessoa.Nome = Console.ReadLine();

                    Console.Write("-> Idade: ");
                    pessoa.Idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("-> Salário: ");
                    pessoa.Salario = Convert.ToDouble(Console.ReadLine());

                    listaPessoas.Add(pessoa);

                    Console.WriteLine("Pessoa cadastrada com sucesso!");
                    
                    Console.WriteLine("-----------------------------------");

                    Console.Write("Deseja cadastrar mais alguma pessoa? [s/N]: ");
                    
                    string resposta = Console.ReadLine()!.ToLower();

                    if(resposta != "s")
                    {
                        break;
                    }
                }

                break;
            }
        case 2:
            {

                if(listaPessoas.Count == 0)
                {
                    MostrarErro("Nenhuma pessoa foi registrada ainda!");
                    break;
                }

                while (true)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Iniciando a consulta de uma pessoa:");


                    Console.Write($"> Posição (entre 0 e {listaPessoas.Count - 1}): ");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    if (pos >= 0 && pos < listaPessoas.Count)
                    {
                        var pessoa = listaPessoas[pos];
                        Console.WriteLine("----------------------");
                        MostrarPessoa(pessoa);
                        Console.WriteLine("----------------------");

                    }
                    else
                    {
                        MostrarErro("Posição Inválida!");
                    }

                    Console.WriteLine("-----------------------------------");

                    Console.Write("Deseja consultar mais alguma pessoa? [s/N]: ");
                    
                    string resposta = Console.ReadLine()!.ToLower();

                    if (resposta != "s")
                    {
                        break;
                    }
                }

                break;
            }
        case 3:
            {
                Console.WriteLine($"Listando as {listaPessoas.Count} pessoas:");

                for (int i = 0; i < listaPessoas.Count; i++)
                {
                    var pessoa = listaPessoas[i];
                    Console.WriteLine($"-----------[{i}]-----------");
                    MostrarPessoa(pessoa);
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

Console.WriteLine();