using AppAumentoSalario.RegrasDeNegocio;


string opc1; // definir a continuidade do loop

var obj = new Reajuste();

do //começo do Loop
{
    Console.Clear();

    Console.WriteLine("############ SISTEMA DE REAJUSTE DE SALÁRIO ############");    
    Console.WriteLine();

    Console.Write("> Informe o salário atual............................: ");
    obj.SalarioAtual = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Escolha a categoria para dar aumento: ");
    Console.WriteLine("- [1] Auxiliar de Servições Gerais | 10%");
    Console.WriteLine("- [2] Técnicos operativos | 15%");
    Console.WriteLine("- [3] Supervisores | 17%");
    Console.WriteLine("- [4] Reajuste Livre");
    Console.WriteLine("- [5] Sair do Sistema");
    
    Console.Write("> OPC.........................................: ");
    int opc2 = Convert.ToInt32(Console.ReadLine());
    
    switch (opc2)
    {//começo case
        case 1: 
            {
                obj.CalcularAumentoAuxiliarDeServicosGerais();
                break; 
            }
        case 2:
            {
                obj.CalcularAumentoTecnicosOperativos();
                break;
            }
        case 3:
            {
                obj.CalcularAumentoSupervisores();
                break;
            }
        case 4:
            {
                Console.Write("> Percentual de Aumento.......................: ");

                double percentualDesejado = Convert.ToDouble(Console.ReadLine());
                obj.CalcularAumentoLivre(percentualDesejado);
 
                break;
            }

        case 5:
            {
                Console.WriteLine("Você escolheu: SAIR.");
                opc1 = "S";
                continue;
            }
        default: 
            {
                var corAtual = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OPÇÃO INVÁLIDA!");
                Console.ForegroundColor = corAtual;

                Console.Write("Deseja sair? [s/N]: ");
                opc1 = Console.ReadLine()!;

                continue;
            }    

    }//fim case

    Console.WriteLine("< Salário Reajustado: {0:C}", obj.SalarioReajustado);

    Console.Write("Deseja sair? [s/N]: ");
    opc1 = Console.ReadLine()!;
} while (opc1.ToUpper() != "S"); // fim do loop 

Console.WriteLine("Fim.");