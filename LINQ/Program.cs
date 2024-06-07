using LINQ;

string[] paises = { "Colombia","Ecuador","Mexico"};

var paises1 = paises.Concat(paises);
foreach (var paise in paises1) 
{
    Console.WriteLine(paise);
}