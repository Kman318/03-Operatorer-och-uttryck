int a = 5;
int b = 5;

Console.WriteLine($"Prefix ++a: {++a}"); // Ökar a med 1 och returnerar det nya värdet
Console.WriteLine($"Postfix b++: {b++}"); // Returnerar det nuvarande värdet av b och ökar sedan b med 1

Console.WriteLine($"\nNuvarande värde av a: {a}");
Console.WriteLine($"Nuvarande värde av b: {b}");



Console.WriteLine("\nTryck på en tangent för att fortsätta...");
Console.ReadKey();