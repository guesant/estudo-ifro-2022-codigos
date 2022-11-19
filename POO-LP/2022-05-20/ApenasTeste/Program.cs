using FerramentasBiblioteca.Validacoes;
using FerramentasBiblioteca.Calculos;


(string agencia, string conta) PerguntarContaBancaria()
{
    Console.Write("Agencia: ");
    string agencia = Console.ReadLine()!;

    Console.Write("Conta: ");
    string conta = Console.ReadLine()!;


    return (agencia, conta);
}

void ValidarCpf()
{
    Console.Write("Digite o CPF: ");
    string cpf = Console.ReadLine()!;

    Console.WriteLine(ValidacoesSociais.ValidarCpf(cpf));
}

void ValidarCnpj()
{
    Console.Write("Digite o CNPJ: ");
    string cnpj = Console.ReadLine()!;

    Console.WriteLine(ValidacoesSociais.ValidarCnpj(cnpj));
}


void ValidarBancoBB()
{
    (string agencia, string conta) = PerguntarContaBancaria();
    Console.WriteLine(ContaBancaria.ValidarContaBB(agencia, conta));
}


void ValidarBancoCitiBank()
{
    (string agencia, string conta) = PerguntarContaBancaria();
    Console.WriteLine(ContaBancaria.ValidarContaCitiBank(agencia, conta));
}

void ValidarBancoCEF()
{
    (string agencia, string conta) = PerguntarContaBancaria();

    Console.WriteLine(ContaBancaria.ValidarContaCEF(agencia, conta));
}

void ValidarBancoItau()
{
    (string agencia, string conta) = PerguntarContaBancaria();

    Console.WriteLine(ContaBancaria.ValidarContaItau(agencia, conta));
}

void ValidarCartao()
{
    Console.Write("Digite o número do cartão: ");
    string numero = Console.ReadLine()!;

    Console.WriteLine(Cartoes.ValidarCartaoDeCredito(numero));
}


void SomarDiasParaUmaData()
{
    Console.Write("Digite a data inicial [DD/MM/AAAA]: ");
    string dataInicial = Console.ReadLine()!;

    Console.Write("Digite a quantidade de dias: ");
    int quantDias = Convert.ToInt32(Console.ReadLine()!);

    Console.WriteLine(MDatas.SomarDiasParaUmaData(dataInicial, quantDias));
}

void SomarDiasAPartirDataAtual()
{
    Console.Write("Digite a quantidade de dias: ");
    int quantDias = Convert.ToInt32(Console.ReadLine()!);

    Console.WriteLine(MDatas.SomarDiasAPartirDataAtual(quantDias));
}


void DiferencaDataInicialEDataHojeEmAnos()
{
    Console.Write("Digite a data inicial [DD/MM/AAAA]: ");
    string dataInicial = Console.ReadLine()!;

    Console.WriteLine(MDatas.DifDataInicialEDataDeHojeEmAnos(dataInicial));
}

void DiferencaDataInicialEDataHojeEmMeses()
{
    Console.Write("Digite a data inicial [DD/MM/AAAA]: ");
    string dataInicial = Console.ReadLine()!;

    Console.WriteLine(MDatas.DifDataInicialEDataDeHojeEmMeses(dataInicial));
}

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("============================================");
    Console.WriteLine("[1] Validar CPF");
    Console.WriteLine("[2] Validar CNPJ");
    Console.WriteLine("[3] Validar conta Banco do Brasil");
    Console.WriteLine("[4] Validar conta Citi Bank");
    Console.WriteLine("[5] Validar conta Caixa Econômica Federal");
    Console.WriteLine("[6] Validar conta Itaú");
    Console.WriteLine("[7] Validar Cartão de Crédito");

    Console.WriteLine("[8] Somar dias para uma data");
    Console.WriteLine("[9] Somar dias a partir da data atual");

    Console.WriteLine("[10] Diferença data inicial e data de hoje em anos");
    Console.WriteLine("[11] Diferença data inicial e data de hoje em meses");

    Console.WriteLine("[0] Sair");
    Console.WriteLine("============================================");

    Console.Write(">> ");
    int opc = Convert.ToInt32(Console.ReadLine());

    if(opc == 0)
    {
        break;
    }
    
    Console.WriteLine("============================================");

    switch (opc)
    {
            case 1:
            {
                ValidarCpf();
                break;
            }

            case 2:
            {
                ValidarCnpj();
                break;
            }

            case 3: {
                ValidarBancoBB();
                break;
            }

            case 4:
            {
                ValidarBancoCitiBank();
                break;
            }

            case 5:
            {
                ValidarBancoCEF();
                break;
            }

            case 6:
            {
                ValidarBancoItau();
                break;
            }

            case 7:
            {
                ValidarCartao();
                break;
            }

            case 8:
            {
                SomarDiasParaUmaData();
                break;
            }

            case 9:
            {
                SomarDiasAPartirDataAtual();
                break;
            }

            case 10:
            {
                DiferencaDataInicialEDataHojeEmAnos();
                break;
            }

            case 11:
            {
                DiferencaDataInicialEDataHojeEmMeses();
                break;
            }

        default: {
                Console.Error.Write("Opção Inválida!1");
                Console.ReadKey();
                break;
            }
    }

    Console.Write("Deseja continuar? [s/n]: ");
    
    string resposta = Console.ReadLine()!.ToUpper();
    
    if(resposta == "N")
    {
        break;
    }

    Console.Clear();

}