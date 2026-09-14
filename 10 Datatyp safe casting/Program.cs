object input1 = "Hej Ferro!";
string? text1 = input1 as string; // Säker typomvandling med "as"

Console.WriteLine($"Resultat av as: {text1 ?? "Ingen text"}");

object input2 = 42;
string? text2 = input2 as string; // Säker typomvandling med "as"

Console.WriteLine($"Resultat av as vid fel typ: {text2 ?? "Ingen text"}");



Console.WriteLine("\nTryck på en tangent för att fortsätta...");
Console.ReadKey();