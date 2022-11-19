double valor = Convert.ToDouble(Console.ReadLine());

double valorRestante = valor;

int C100 = (int)valorRestante / 100;
valorRestante = valorRestante % 100;

int C50 = (int)valorRestante / 50;
valorRestante = valorRestante % 50;

int C20 = (int)valorRestante / 20;
valorRestante = valorRestante % 20;

int C10 = (int)valorRestante / 10;
valorRestante = valorRestante % 10;

int C5 = (int)valorRestante / 5;
valorRestante = valorRestante % 5;

int C2 = (int)valorRestante / 2;
valorRestante = valorRestante % 2;

int moedasRestantes = Convert.ToInt32(valorRestante * 100);

int M1 = moedasRestantes / 100;
moedasRestantes = moedasRestantes % 100;

int M050 = moedasRestantes / 50;
moedasRestantes = moedasRestantes % 50;

int M025 = moedasRestantes / 25;
moedasRestantes = moedasRestantes % 25;

int M010 = moedasRestantes / 10;
moedasRestantes = moedasRestantes % 10;

int M005 = moedasRestantes / 5;
moedasRestantes = moedasRestantes % 5;

int M001 = moedasRestantes;

Console.WriteLine("NOTAS:");
Console.WriteLine(C100 + " nota(s) de R$ 100.00");
Console.WriteLine(C50 + " nota(s) de R$ 50.00");
Console.WriteLine(C20 + " nota(s) de R$ 20.00");
Console.WriteLine(C10 + " nota(s) de R$ 10.00");
Console.WriteLine(C5 + " nota(s) de R$ 5.00");
Console.WriteLine(C2 + " nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS:");
Console.WriteLine(M1 + " moeda(s) de R$ 1.00");
Console.WriteLine(M050 + " moeda(s) de R$ 0.50");
Console.WriteLine(M025 + " moeda(s) de R$ 0.25");
Console.WriteLine(M010 + " moeda(s) de R$ 0.10");
Console.WriteLine(M005 + " moeda(s) de R$ 0.05");
Console.WriteLine(M001 + " moeda(s) de R$ 0.01");
