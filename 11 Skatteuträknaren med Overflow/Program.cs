int max = int.MaxValue; // Maxvärdet för en int är 2,147,483,647
Console.WriteLine($"Maxvärde för int: {max}");
int uncheckedMax = unchecked(max + 1); // Överskrider maxvärdet utan att kasta ett undantag
Console.WriteLine($"Värde efter overflow (unchecked): {uncheckedMax}");

checked
{
    try
    {
        int checkedMax = checked(max + 1); // Överskrider maxvärdet och kastar ett undantag
        Console.WriteLine($"Värde efter overflow (checked): {checkedMax}");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Fel: Överskridning av maxvärde för int.");
    }
}


Console.WriteLine("\nTryck på en tangent för att fortsätta...");
Console.ReadKey();