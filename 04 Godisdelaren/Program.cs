int godisar = 23;
int vänner = 4;

int godisPerVän = godisar / vänner;
int resterandeGodis = godisar % vänner;

Console.WriteLine($"Varje vän får {godisPerVän} godisar.");
Console.WriteLine($"Det blir {resterandeGodis} godisar över.");
