bool ärguldMedlem = false;
bool ärSenior = true;
decimal köpBelopp = 550.00m;

bool fårRabatt = ärguldMedlem || ärSenior || köpBelopp > 500;

Console.WriteLine($"Får rabatt: {fårRabatt}");
