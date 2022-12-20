using AppExemplo5.RegrasDeNegocio;

// INÍCIO FUNÇÕES UTILITÁRIAS

int PerguntarUmValor(string msg1 = "primeiro número")
{
    Console.Write("Digite o " + msg1 + ": ");
    var a = Convert.ToInt32(Console.ReadLine());
    return a;
}

(int a, int b) PerguntarDoisValoresInt(string msg1 = "o primeiro número", string msg2 = "o segundo número")
{
    Console.Write("Digite " + msg1 + ": ");
    var a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite " + msg2 + ": ");
    var b = Convert.ToInt32(Console.ReadLine());

    return (a, b);
}

(int a, int b, int c) PerguntarTresValoresInt(string msg1 = "o primeiro número", string msg2 = "o segundo número", string msg3 = "o terceiro número")
{
    Console.Write("Digite " + msg1 + ": ");
    var a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite " + msg2 + ": ");
    var b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite " + msg3 + ": ");
    var c = Convert.ToInt32(Console.ReadLine());

    return (a, b, c);
}

(double a, double b) PerguntarDoisValoresDouble(string msg1 = "o primeiro número", string msg2 = "o segundo número")
{
    Console.Write("Digite " + msg1 + ": ");
    var a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite " + msg2 + ": ");
    var b = Convert.ToDouble(Console.ReadLine());

    return (a, b);
}

// FIM FUNÇÕES UTILITÁRIAS

var calc = new CalculadoraDeValores();//criou objeto

while(true)
{
    Console.WriteLine("");
    Console.WriteLine("---[ CALCULADORA DE VALORES ]---");
    Console.WriteLine("[1] - Somar");
    Console.WriteLine("[2] - Subtrair");
    Console.WriteLine("[3] - Multiplicar");
    Console.WriteLine("[4] - Dividir");
    Console.WriteLine("[5] - Raiz Quadrada");
    Console.WriteLine("[6] - Potência");
    Console.WriteLine("[7] - Fatorial");
    Console.WriteLine("[8] - CalcularDescontoDaCompra");
    Console.WriteLine("[9] - AumentarSalario");
    Console.WriteLine("[10] - CalcularAreaDoRetangulo");
    Console.WriteLine("[11] - VerificarTriangulo");
    Console.WriteLine("[0] - Sair");
    Console.WriteLine("--------------------------------");

    Console.WriteLine("Escolha uma opção:");
    Console.Write(">>> ");

    var opcao = Convert.ToInt32(Console.ReadLine());

    Console.Beep();

    if(opcao == 0)
    {
        // fim do loop
        break;
    }

    Console.Clear();

    Console.WriteLine("================================");

    switch (opcao)
    {
        case 1:
            {
                Console.WriteLine("Você escolheu: SOMA.");
                (var a, var b) = PerguntarDoisValoresInt();
                Console.WriteLine($"> {a} + {b} = {calc.SomaDeValores(a, b)}");
                break;
            }

        case 2:
            {
                Console.WriteLine("Você escolheu: SUBTRAÇÃO.");
                (var a, var b) = PerguntarDoisValoresInt();
                Console.WriteLine($"> {a} - {b} = {calc.SubtracaoDeValores(a, b)}");
                break;
            }

        case 3:
            {
                Console.WriteLine("Você escolheu: MULTIPLICAÇÃO.");
                (var a, var b) = PerguntarDoisValoresInt();
                Console.WriteLine($"> {a} * {b} = {calc.MultiplicacaoDeValores(a, b)}");
                break;
            }

        case 4:
            {
                Console.WriteLine("Você escolheu: DIVISÃO.");
                (var a, var b) = PerguntarDoisValoresInt();
                Console.WriteLine($"> {a} / {b} = {calc.DividirValores(a, b)}");
                break;
            }

        case 5:
            {
                Console.WriteLine("Você escolheu: RAIZ QUADRADA.");
                var a = PerguntarUmValor();
                Console.WriteLine($"> Raiz Quadrada de {a} = {calc.CalcularRaizQuadrada(a)}");
                break;
            }

        case 6:
            {
                Console.WriteLine("Você escolheu: POTENCIAÇÃO.");
                (var a, var b) = PerguntarDoisValoresInt("a base", "o expoente");
                Console.WriteLine($"> {a} ^ {b}  = {calc.CalcularPotencia(a, b)}");
                break;
            }

        case 7:
            {
                Console.WriteLine("Você escolheu: FATORIAL.");
                var a = PerguntarUmValor();
                Console.WriteLine($"> {a}!  = {calc.CalcularFatorial(a)}");
                break;
            }

        case 8:
            {
                (double valorCompra, double desconto) = PerguntarDoisValoresDouble("o valor da compra", "o % de desconto");
                Console.WriteLine($"> {valorCompra} - {desconto}% = {calc.CalcularDescontoDaCompra(valorCompra, desconto)}");
                break;
            }

        case 9:
            {
                (double salarioAtual, double aumento) = PerguntarDoisValoresDouble("o salário atual do funcionário", "o % do aumento");
                Console.WriteLine($"> {salarioAtual} + {aumento}% = {calc.AumentarSalario(salarioAtual, aumento)}");
                break;
            }

        case 10:
            {
                (int a, int b) = PerguntarDoisValoresInt("a altura", "a largura");
                Console.WriteLine($"> Área: {calc.CalcularAreaDoRetangulo(a, b)}");
                break;
            }
        
        case 11:
            {
                (int a, int b, int c) = PerguntarTresValoresInt("o lado a", "o lado b", "o lado c");
                Console.WriteLine($"> Resultado: {calc.VerificarTriangulo(a, b, c)}");
                break;
            }

        default:
            {
                Console.WriteLine("Opção Inválida.");
                break;
            }
    }

    Console.WriteLine("================================");

    Console.Write("Deseja continuar? [S/n]: ");
    var resposta = Console.ReadLine();

    if(resposta == "n")
    {
        // fim do loop
        break;
    }

    Console.Clear();
}

Console.WriteLine("Fim.");