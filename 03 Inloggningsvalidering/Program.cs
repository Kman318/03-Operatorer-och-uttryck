string korrektAnvändarnamn = "admin";
string korrektLösenord = "hemligt";

Console.Write("Ange användarnamn: ");
string användarnamn = Console.ReadLine()!;
Console.Write("Ange lösenord: ");
string lösenord = Console.ReadLine()!;

bool ärInloggad = användarnamn == "admin" && lösenord == "hemligt";
Console.WriteLine($"Användare inloggad: {ärInloggad}");