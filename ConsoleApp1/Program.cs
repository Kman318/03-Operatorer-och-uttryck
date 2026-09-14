int tal = 500;
double implicitTal = tal; // Implicit konvertering från int till double
double stortTal = 123.45;
int explicitTal = (int)stortTal; // Explicit konvertering från double till int

Console.WriteLine($"Implicit konvertering: {implicitTal}");
Console.WriteLine($"Explicit konvertering: {explicitTal}");