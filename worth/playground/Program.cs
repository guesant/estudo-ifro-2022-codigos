using System;
class boboDAcorte
{
    static void Main(string[] args)
    {
        double salario = Convert.ToDouble(Console.ReadLine());
        double imposto = 0;

        if(salario <= 2000)
        {
            imposto = 0;
        }
        else if (salario > 2000 && salario <= 3000)
        {
            imposto = (salario - 2000) * 8 / 100;
        }
        else if(salario > 3000 && salario <= 4500)
        {
            // vamos adicionar o imposto de 8% que é aplicado nos primeiros R$ 1.000,00 (3000 - 2000)
            // 8% de 1000 = 80

            imposto = 80 +  ((salario - 3000) * 18 / 100);
        }
        else if (salario >= 4500)
        {
            // vamos adicionar o imposto de 8% que é aplicado nos primeiros R$ 1.000,00 (3000 - 2000)
            // e também o imposto de 18% que é aplicado sobre R$ 1.500,00 (4500 - 3000)
            
            // 8% de 1000 = 80
            // 18% de 1000 = 270

            imposto = 80 + 270 + ((salario - 4500) * 28 / 100);
        }

        if(imposto == 0) {
            Console.WriteLine("Isento");
        } else {
            Console.WriteLine("R$ " + imposto.ToString("0.00"));
        }
      
        Console.ReadKey();
    }
            
}