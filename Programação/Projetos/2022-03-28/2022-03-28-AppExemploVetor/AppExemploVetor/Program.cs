int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o valor para a posição {i}: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("--------------------------------");



int k = 0;

foreach(int numero in numeros)
{
    //Console.WriteLine($"Só sei que o vetor possúi este número: {numero}. A posição em que ele está ?w Fds! SE VIRA.");
    Console.WriteLine($"k: {k} | numero: {numero}");
    k++;
}

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"O valor que está na posição {i + 1}: {numeros[i]}");
//}

Console.Write("Informe a posição que você deseja consultar: ");
int pos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Número na posição {pos}: {numeros[pos]}.");