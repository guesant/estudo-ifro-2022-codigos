using ConseAppExemplosConstrutores.RegrasDeNegocio;

int PerguntarInteir(string mensagem)
{
    Console.Write(mensagem);
    
    try
    {
        return Convert.ToInt32(Console.ReadLine()!);
    } catch (Exception)
    {
        return 0;
    }
}

string PerguntarString(string mensagem)
{
    Console.Write(mensagem);

    try
    {
        return Console.ReadLine()!;
    }
    catch (Exception)
    {
        return "";
    }
}

// PESSOA

var pessoa = new Pessoa("Gabriel", "000.111.222-33");
pessoa.DataNasc = new DateTime(2005, 9, 13);

Console.WriteLine("========================================");
Console.WriteLine($"Nome...................: {pessoa.Nome}");
Console.WriteLine($"CPF....................: {pessoa.CPF}");
Console.WriteLine($"Data de Nascimento.....: {pessoa.DataNasc}");
pessoa.BingBingBang();
Console.WriteLine("========================================");

// FIM PESSOA

Console.WriteLine();
Console.WriteLine("=========================");
Console.WriteLine();

// CARRO

//var fusca = new Carro("fusca", "azul", "A419B3D", 2005);

var fusca = new Carro(
    PerguntarString("Digite o modelo do carro...........: "),
    PerguntarString("Digite a cor do carro..............: "),
    PerguntarInteir("Digite o ano de fabricação do carro: "),
    PerguntarString("Digite a placa do carro............: ")
);

Console.WriteLine("========================================");
Console.WriteLine($"Placa..................: {fusca.Placa}");
Console.WriteLine($"Modelo do Carro........: {fusca.ModeloCarro}");
Console.WriteLine($"Cor do Carro...........: {fusca.CorDoCarro}");
Console.WriteLine($"Ano de Fabricacao......: {fusca.AnoFabricacao}");
Console.WriteLine("========================================");

// FIM CARRO
