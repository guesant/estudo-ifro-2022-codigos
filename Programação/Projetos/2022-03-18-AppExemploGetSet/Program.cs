using AppExemploGetSet.RegrasDeNegocio;

// eu não estou chamando o CalcularArea, pois o mesmo
// é chamado sempre que eu mudo o LadoA ou LadoB;

var calculoDeArea = new CalculoDeArea();
calculoDeArea.LadoA = 7;
calculoDeArea.LadoB = 9;

//

var calculoDeArea2 = new CalculoDeArea();
calculoDeArea2.LadoA = 10;
calculoDeArea2.LadoB = 20;

//Console.WriteLine($"- Área 1: {calculoDeArea.Area} U.M.²;");
//Console.WriteLine($"- Área 2: {calculoDeArea.Area} U.M.²;");

calculoDeArea.MostrarArea();
calculoDeArea2.MostrarArea();