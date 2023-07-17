/* //Opdracht B
//Declaraties
string voornaam = "Bryan";
char variabele1 = 'C';
int nummer1 = 123;
double nummer2 = 1.5;
bool status = false;
double rest = nummer1 % nummer2;

//Tonen in de console
Console.WriteLine("Hello " + voornaam);
Console.WriteLine(Convert.ToString(variabele1) + " " + nummer1);
Console.WriteLine(nummer2 + " " + status);
Console.WriteLine(rest);
Console.ReadKey();
Console.Clear();

//Opdracht C
int temperatuur;
int fahrenheit;
int euro;
int dollar;

Console.WriteLine("Geef een temperatuur in Celsius");
temperatuur = Convert.ToInt32(Console.ReadLine());
fahrenheit = Convert.ToInt32(temperatuur * 1.8 + 32);
Console.WriteLine("Deze temperatuur is omgezet in fahrenheit: " + fahrenheit);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Geef een bedrag in euro");
euro = Convert.ToInt32(Console.ReadLine());
dollar = Convert.ToInt32(euro * 1.16);
Console.WriteLine(euro + " euro is " + dollar + " dollar");
Console.ReadKey();
Console.Clear(); */

//Opdracht D
string geslacht;
int lengte;
int polsomtrek;
int ideale_gewicht_man;
int ideale_gewicht_vrouw;

Console.WriteLine("Bent u een man of een vrouw?");
geslacht = (Console.ReadLine().ToLower());
if (geslacht == "man")
{
    Console.WriteLine("Geef uw lichaamslengte in cm");
    lengte = Convert.ToInt32(Console.ReadLine());
    ideale_gewicht_man = Convert.ToInt32((lengte - 100) * 0.9);
    Console.WriteLine("Uw ideale gewicht is " + ideale_gewicht_man + " kilogram");
    Console.ReadKey();
    Console.Clear();
}
else if (geslacht == "vrouw")
{
    Console.WriteLine("Geef uw lichaamslengte in cm");
    lengte = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Geef uw polsomtrek in cm");
    polsomtrek = Convert.ToInt32(Console.ReadLine());
    ideale_gewicht_vrouw = Convert.ToInt32((lengte + 4 * polsomtrek - 100)/2);
    Console.WriteLine("Uw ideale gewicht is " + ideale_gewicht_vrouw + " kilogram");
    Console.ReadKey();
    Console.Clear();
}
else
{
    Console.WriteLine("Foutieve invoer gedetecteerd");
    Console.ReadKey();
    Console.Clear();
}

string taal;
Console.WriteLine("Selecteer een taal (Nederlands, Engels, Frans, Duits of Spaans): ");
taal = Console.ReadLine().ToLower();

switch (taal)
{
    case "nederlands":
        Console.WriteLine("Tot ziens!");
        break;
    case "engels":
        Console.WriteLine("Bye!");
        break;
    case "frans":
        Console.WriteLine("Au Revoir!");
        break;
    case "duits":
        Console.WriteLine("Tschüss!");
        break;
    case "spaans":
        Console.WriteLine("¡Adiós!");
        break;
}
Console.ReadKey();
Console.Clear();