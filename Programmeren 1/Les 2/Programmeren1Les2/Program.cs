//Opdracht A

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(Math.Pow(2, i).ToString());
//}
//Console.ReadKey();

//int i = 0;
//while (i < 10)
//{
//    i++;
//    Console.WriteLine(Math.Pow(2, i).ToString());
//    if (i > 10)
//    {
//        break;
//    }
//}
//Console.ReadKey();

//int i = 0;
//do
//{
//    i++;
//    Console.WriteLine(Math.Pow(2, i).ToString());
//}
//while (i < 10);
//Console.ReadKey();

//int max = int.MinValue;

//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Voer een geheel getal in: ");
//    int invoer = int.Parse(Console.ReadLine());

//    if (invoer > max)
//    {
//        max = invoer;
//    }
//}

//Console.WriteLine("Het grootste ingevoerde getal is: " + max);
//Console.ReadKey();
//Console.Clear();

//Opdracht B
//Console.WriteLine("Hoeveel getallen wil u invoeren?");
//int aantal = int.Parse(Console.ReadLine());
//Console.Clear();

//double[] invoer = new double[aantal];
//for (int i = 0; i < invoer.Length; i++)
//{
//    Console.Write("Voer een geheel getal in: ");
//    invoer[i] = double.Parse(Console.ReadLine());
//}
//Console.Clear ();

//double som = invoer.Sum();
//double gemiddelde = Math.Round((som / aantal), 3);
//Console.WriteLine("De som van deze getallen is " + som + ".");
//Console.WriteLine("Het gemiddelde van deze getallen is " + gemiddelde + ".");
//Console.ReadKey();
//Console.Clear();

//string[] namen = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Vul een naam in: ");
//    string naam = Console.ReadLine();
//    namen[i] = naam;
//}
//Console.Clear();

//Console.WriteLine("De ingevoerde namen zijn:");
//foreach (string naam in namen)
//{
//    Console.WriteLine(naam);
//}
//Console.ReadKey ();
//Console.Clear();

//const int maxAantalNamen = 10;
//Console.Write("Hoeveel namen wil je invoeren? (maximaal 10): ");
//int aantalNamen = int.Parse(Console.ReadLine());

//aantalNamen = Math.Min(aantalNamen, maxAantalNamen); // Beperk het aantal namen tot maxAantalNamen

//string[] namen = new string[aantalNamen];

//int teller = 0;
//string invoer;

//while (teller < aantalNamen)
//{
//    Console.Write("Voer een naam in (of typ 'stop' om te stoppen): ");
//    invoer = Console.ReadLine();

//    if (invoer.ToLower() == "stop")
//    {
//        break;
//    }

//    if (string.IsNullOrWhiteSpace(invoer))
//    {
//        Console.WriteLine("Lege invoer is niet toegestaan. Probeer opnieuw.");
//        continue;
//    }

//    namen[teller] = invoer;
//    teller++;
//}

//Console.WriteLine("De ingevoerde namen zijn:");
//for (int i = 0; i < teller; i++)
//{
//    Console.WriteLine(namen[i]);
//}
//Console.ReadKey();
//Console.Clear();

//Opdracht C
int n = 15; // Aantal getallen om af te drukken

// Initialisatie van de eerste twee getallen van de Fibonacci-reeks
int a = 0;
int b = 1;

Console.WriteLine("De eerste {0} getallen van de Fibonacci-reeks zijn:", n);

// Afdrukken van de Fibonacci-reeks
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);

    int temp = a;
    a = b;
    b = temp + b;
}

Console.ReadKey();
Console.Clear();

Console.Write("Voer uw inzet in (tussen 5 en 100 euro): ");
int inzet = int.Parse(Console.ReadLine());

if (inzet < 5 || inzet > 100)
{
    Console.WriteLine("Ongeldige inzet. De inzet moet tussen 5 en 100 euro liggen.");
    return;
}

int multiplier = 0;
int aantalZessen = 0;
int aantalGelijkeWorpen = 0;
int aantalEenWorpen = 0;
int aantalZessenTotNuToe = 0;

Random random = new Random();

for (int worp = 1; worp <= 4; worp++)
{
    int worp1 = random.Next(1, 7);
    int worp2 = random.Next(1, 7);

    Console.WriteLine("Worp {0}: {1} + {2}", worp, worp1, worp2);

    if (worp1 == 6 && worp2 == 6)
    {
        aantalZessen++;
    }

    if (worp1 == worp2)
    {
        aantalGelijkeWorpen++;
    }

    if (worp1 == 1 && worp2 == 1)
    {
        aantalEenWorpen++;
        multiplier = 0;
    }

    if (aantalZessen > aantalZessenTotNuToe)
    {
        aantalZessenTotNuToe = aantalZessen;
        if (aantalZessenTotNuToe == 4)
        {
            multiplier += 2;
        }
        else
        {
            multiplier += 50;
        }
    }
    else if (aantalGelijkeWorpen > 0)
    {
        multiplier += 10;
    }
}

int winst = inzet * multiplier;
Console.WriteLine("Uw winst: {0} euro", winst);

Console.ReadKey();
Console.Clear();