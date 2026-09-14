string? text = null;
int längd = text?.Length ?? 0; // Om text är null, sätt längd till 0

Console.WriteLine($"Stränglängd: {längd}");





Console.WriteLine("\nTryck på en tangent för att fortsätta...");
Console.ReadKey();