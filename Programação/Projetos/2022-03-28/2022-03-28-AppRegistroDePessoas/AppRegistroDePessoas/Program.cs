using AppRegistroDePessoas.RegrasDeNegocio;

Pessoa[] listaPessoas = new Pessoa[2];

for (int i = 0; i < listaPessoas.Length; i++)
{
    Console.WriteLine("------------------------------------");
    
    Console.WriteLine($"Início do Cadastro Nº {i+1}.");

    Pessoa pessoa = new Pessoa();

    // INÍCIO Preenchimento dos Dados da Pessoa
    
    Console.Write("-> Digite o nome da pessoa.: ");
    pessoa.Nome = Console.ReadLine();
    
    Console.Write("-> Digite a idade da pessoa: ");
    pessoa.Idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("-> Digite o RG da pessoa...: ");
    pessoa.RegistroGeral = Console.ReadLine();

    // FIM Preenchimento dos Dados da Pessoa

    // guardar pessoa no vetor (no arquivo)
    listaPessoas[i] = pessoa;

    Console.WriteLine($"Fim do Cadastro Nº {i + 1}.");
}

Console.WriteLine("-------------------------------------");

//Console.Write("Informe a posição: ");
//int pos = Convert.ToInt32(Console.ReadLine());
//var pessoaEscolhida = listaPessoas[pos];

Console.Write("Informe o nome da pessoa: ");
string nome = Console.ReadLine();
var pessoaEscolhida = listaPessoas.Where(pe => pe.Nome == nome).First();

if(pessoaEscolhida != null)
{
    Console.WriteLine($"- Nome.: {pessoaEscolhida.Nome}");
    Console.WriteLine($"- Idade: {pessoaEscolhida.Idade}");
    Console.WriteLine($"- RG...: {pessoaEscolhida.RegistroGeral}");

} else
{
    Console.WriteLine("Pessoa não encontrada!");
}


Console.WriteLine("-------------------------------------");
