//Opdracht A - Hello world!
//Maak deze Console App aan

//Opdracht B - Variabelen
//Maak een variabele aan. Dit is een string die `voornaam` heet. Vul deze met je eigen naam.
using System;

string voornaam = "Bryan";

//Zorg dat het programma geen “Hello world!” meer laat zien, maar “Hello “ gevolgd door je
//eigen naam. Maak hierbij gebruik van de variabele aangemaakt bij 1.
Console.WriteLine("Hello " + voornaam);

//Declareer de volgende variabelen met het juiste type:
//variabele1 = C (C is een letter)
//nummer1 = 123 (123 is een geheel getal)
//nummer2 = 1.5 (1.5 is een komma getal)
//status = false (false is een boolean)
char variabele1 = 'C';
int nummer1 = 123;
double nummer2 = 1.5;
bool status = false;

//Toon in de Console (na de welkomstregel “Hello...”) de volgende informatie:
//C 123
//1.5 false
Console.WriteLine(Convert.ToString(variabele1) + " " + nummer1);
Console.WriteLine(nummer2 + " " + status);

//Declareer een nieuwe variabele die rest wordt genoemd.
//De waarde van rest is nummer1 % nummer2.
double rest = nummer1 % nummer2;

//Toon rest in de console.
Console.WriteLine(rest);

//Opdracht C - Interactief programma
//Voeg de volgende code toe aan de bij opdracht B gemaakte code, op de plek van de ReadKey
//instructie.
Console.ReadKey();
Console.Clear();

//Maak een variabele (integer) aan die temperatuur heet.
int temperatuur;

//. Laat de temperatuur inlezen door ReadLine() te gebruiken en print voordat de invoer
//gegeven moet worden “Geef een temperatuur in Celsius” in de console.
Console.WriteLine("Geef een temperatuur in Celsius");
temperatuur = Convert.ToInt32(Console.ReadLine());

//Zorg er voor dat na invoer van de gebruiker de temperatuur in Fahrenheit wordt berekend.
//De berekening hiervoor is: ℉ = ℃ ∙ 1.8 + 32.
int fahrenheit = Convert.ToInt32(temperatuur * 1.8 + 32);
Console.WriteLine("Deze temperatuur is omgezet in fahrenheit: " + fahrenheit);

//Voeg na het antwoord op de temperatuurconversie een nieuwe Console.Clear() toe en maak
//hierna nog een conversiemechanisme. De invoer komt ditmaal in een integer genaamd
//euro en de uitvoer is in dollar. De omrekenkoers waar jullie mee mogen rekenen is 1 EUR
//is 1.16 USD
Console.ReadKey();
Console.Clear();

Console.WriteLine("Geef een bedrag in euro");
int euro = Convert.ToInt32(Console.ReadLine());
int dollar = Convert.ToInt32(euro * 1.16);

//Verander je gemaakte valuta conversie zo dat de output als volgt op één regel op het scherm
//komt: “X EUR is Y USD”. X en Y worden hierbij vervangen door respectievelijk het ingevoerde
//aantal euros en het berekende aantal dollars.
Console.WriteLine(euro + " euro is " + dollar + " dollar");

//Opdracht D - If
//Breid je programma uit met een nieuwe overgang naar een nieuw scherm, na het
//converteren.Hier gaan we het ideale gewicht van iemand berekenen.
Console.ReadKey();
Console.Clear();

//Nu gaan we bezig met ideaal gewicht berekenen. Vraag hier daarvoor de gebruiker of hij/zij
//een man of vrouw is.
Console.WriteLine("Bent u een man of een vrouw?");
string geslacht = (Console.ReadLine().ToLower());

//Als er voor man wordt gekozen, wordt het ideale gewicht berekent met behulp van de
//lichaamslengte in cm. Laat dit invoeren en gebruik dan de volgende berekening om het
//ideale gewicht op het scherm te tonen: (lengte − 100) ∙ 0.9.
//Als er voor vrouw wordt gekozen is naast de lichaamslengte ook de polsomtrek in cm nodig.
//Het ideale gewicht voor een vrouw wordt berekend met de formule:
//(lengte + 4 ∙ polsomtrek − 100)/ 2.
int lengte;
int polsomtrek;
int ideale_gewicht_man;
int ideale_gewicht_vrouw;

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
    ideale_gewicht_vrouw = Convert.ToInt32((lengte + 4 * polsomtrek - 100) / 2);
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

//Voeg nog een nieuwe overgang toe en laat hier de gebruiker een taal kiezen (met minstens
//de opties Nederlands, Engels, Frans, Duits en Spaans). Hierna moet het programma “Tot
//ziens” op het scherm tonen in de gekozen taal.
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