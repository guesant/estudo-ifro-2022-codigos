// Licença: GPLv3
// Versão: v0.0.2 - 2022-03-25
// Autor: Gabriel R. Antunes

using AppExemploDesc.RegrasDeNegocio;

// Funções Utilitárias

void ImprimirCabecalho()
{
    Console.WriteLine("====================================");
    Console.WriteLine("==[     SISTEMA DE DESCONTOS     ]==");
    Console.WriteLine("====================================");
    Console.WriteLine("");
}

void ImprimirOpcoes ()
{
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] DESCONTO MASTER | 15%");
    Console.WriteLine("[2] DESCONTO VIP | 10%");
    Console.WriteLine("[3] DESCONTO COMUM | 5%");
    Console.WriteLine("[4] DESCONTO DO GERENTE");
    Console.WriteLine("[5] SAIR");
}

void ImprimirMensagemOpcaoInvalida()
{
    var corAtual = Console.ForegroundColor;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("");
    Console.WriteLine("=[xxxxxxxxxxxxxxxxxxxxxx]=");
    Console.WriteLine("=[>  Opção Inválida!!  <]=");
    Console.WriteLine("=[xxxxxxxxxxxxxxxxxxxxxx]=");
    Console.WriteLine("");
    Console.ForegroundColor = corAtual;
}

void EspereContinuar ()
{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

void ImprimirSeparadorTipoLinha()
{
    Console.WriteLine(new string('-', 36));
}

int? PerguntarOpcaoDesejada() {
    try
    {
        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc < 1 || opc > 5)
        {
            throw new Exception();
        }
        return opc;
    }
    // caso não seja um número valido ou o número está fora do conjunto aceitável.
    catch (Exception)
    {
        return null;
    }
}

// Fim Funções Utilitárias

var desconto = new Desconto();

while (true)
{
    Console.Clear();

    ImprimirCabecalho();
    ImprimirSeparadorTipoLinha();
    ImprimirOpcoes();
    ImprimirSeparadorTipoLinha();

    Console.WriteLine("");
    Console.Write("> Opção desejada: ");

    var opc = PerguntarOpcaoDesejada();

    if(opc == null)
    {
        ImprimirMensagemOpcaoInvalida();
        EspereContinuar();
        continue;
    }

    // escolheu sair
    if(opc == 5)
    {
        break;
    }

    Console.WriteLine("");
    
    ImprimirSeparadorTipoLinha();
    Console.Write("-> Digite o valor da compra: ");
    desconto.ValorCompra = Convert.ToDouble(Console.ReadLine());
    ImprimirSeparadorTipoLinha();

    switch (opc)
    {
        // master
        case 1: 
        {
            Console.WriteLine("<- Você escolheu: Desconto Master.");
            desconto.CalcularDescontoMaster();
            break;
        }

        // vip
        case 2:
        {
            Console.WriteLine("<- Você escolheu: Desconto VIP.");
            desconto.CalcularDescontoVip();
            break;
        }

        // comum
        case 3:
        {
            Console.WriteLine("<- Você escolheu: Desconto Comum.");
            desconto.CalcularDescontoComum();
            break;
        }

        // gerente
        case 4:
        {
            Console.WriteLine("<- Você escolheu: Desconto do Gerente.");
            Console.Write("-> Digite o percentual de desconto desejado: ");
            desconto.CalcularDescontoGerente(Convert.ToDouble(Console.ReadLine()));
            break;
        }
    }

    ImprimirSeparadorTipoLinha();
    Console.WriteLine("<- Valor Final: {0:C}.", desconto.ValorFinal);
    ImprimirSeparadorTipoLinha();

    Console.WriteLine("");
    EspereContinuar();
}

Console.WriteLine("Fim.");