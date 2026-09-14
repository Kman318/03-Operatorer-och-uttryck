Console.Write("Mata in täljare: ");
double täljare = double.Parse(Console.ReadLine()!);
Console.Write("Mata in nämnare: ");
double nämnare = double.Parse(Console.ReadLine()!);

double resultat = (nämnare != 0) ? täljare / nämnare : double.NaN;
Console.WriteLine(nämnare == 0 ? "Fel: Nämnare får inte vara noll." : $"Resultat: {resultat}");


Console.WriteLine("\nTryck på en tangent för att fortsätta...");
Console.ReadKey();