decimal grundPris = 120.00m;
int antal = 3;
decimal totalPris = grundPris * antal;

if (antal >= 3)
{
    decimal rabatt = totalPris * 0.10m; // 10% rabatt
    totalPris -= rabatt;
}

Console.WriteLine("Det rabatterade priset är: " + totalPris);

Console.Write("Hej");
Console.ReadKey();