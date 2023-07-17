using System;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Security.Cryptography;

namespace Week4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Opdracht A
            Console.Write("Geef je invoer: ");
            string input = Console.ReadLine();

            #region code opdracht A
            string s1 = "Sarah";
            string s2 = "Deadpool";

            string middelsteLettersS1 = MiddelsteLetter(s1);
            string middelsteLettersS2 = MiddelsteLetter(s2);
            string middelsteLettersInput = MiddelsteLetter(input);

            Console.WriteLine("Middelste letter(s) van 'Sarah': " + middelsteLettersS1);
            Console.WriteLine("Middelste letter(s) van 'Deadpool': " + middelsteLettersS2);
            Console.WriteLine("Middelste letter(s) van ingevoerde string: " + middelsteLettersInput);
            #endregion

            Console.ReadKey();
            Console.Clear();

            //Opdracht B
            string tekst = "Jos";
            int index;

            Console.WriteLine("Welke letter wil u teruggeven? Geef het indexnummer. ");
            index = int.Parse(Console.ReadLine());

            char karakter = LetterOpIndex(tekst, index);

            Console.WriteLine(karakter);

            Console.ReadKey();
            Console.Clear();

            //Opdracht C
            Console.Write("Geef een tekst: ");
            string tekst1 = Console.ReadLine();

            string tekst2 = "Dit zijn vier woorden.";

            AantalWoorden(tekst1);
            AantalWoorden(tekst2);

            Console.ReadKey();
        }

        //Opdracht A - Een eenvoudige methode
        //Neem deze code over.De methode MiddelsteLetter is nog leeg.
        //Vul de methode MiddelsteLetter zodat deze de middelste letter van een meegegeven string
        //teruggeeft.Gebruik de eigenschap Length van een string om de Lengte te bepalen.

        static string MiddelsteLetter(string tekst)
        {
            int lengte = tekst.Length;
            int middelsteIndex = lengte / 2;

            if (lengte % 2 == 0)
            {
                // Als de lengte van de string even is, geef dan de 2 middelste letters terug
                return tekst.Substring(middelsteIndex - 1, 2);
            }
            else
            {
                // Als de lengte van de string oneven is, geef dan het middelste teken terug
                return tekst[middelsteIndex].ToString();
            }
        }

        //Opdracht B - Een uitgebreide methode
        //Maak een nieuwe methode genaamd LetterOpIndex die een character teruggeeft.Zorg
        //ervoor dat deze methode 2 parameters meekrijgt, een string genaamd tekst en een integer
        //genaamd index.

        //Laat de aangemaakte methode de derde letter van de meegegeven string (tekst)
        //teruggeven.Test dit door de methode aan te roepen in de Main(doe dit met de string “Jos”
        //en het getal 0).

        //Pas de methode zo aan dat niet de derde letter wordt teruggegeven maar de letter op de
        //meegegeven index.

        static char LetterOpIndex(string tekst, int index)
        {
            if (tekst.Length >= 3)
            {
                return tekst[index];
            }
            else
            {
                Console.WriteLine("De opgegeven tekst heeft niet genoeg karakters!");
                return '\0'; // retourneer null character als de tekst niet genoeg karakters heeft
            }
        }

        //Opdracht C - Een methode om woorden te tellen
        //Maak een nieuw methode genaamd AantalWoorden.Zorg dat er een tekst meegegeven kan
        //worden als parameter.De functie heeft geen returnwaarde.

        static void AantalWoorden(string tekst)
        {
            string[] woorden = tekst.Split(' ');
            int aantalWoorden = woorden.Length;

            Console.WriteLine("Tekst: " + tekst);
            Console.WriteLine("Aantal woorden: " + aantalWoorden);
        }
    }
}
