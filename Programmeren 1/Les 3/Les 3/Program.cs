using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Les_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opdracht A - Geneste lusstructuren
            //Schrijf een programma met twee geneste for-lussen om een patroon van "-" en "*" af te drukken in een 10x10 rooster.
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        if ((x * y) <= 25)
                            Console.Write("-");
                        else
                            break;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            //Opdracht B - Lists
            //Breid het programma van opdracht A uit door de console te clearen en daarna uit met de
            //mogelijkheid om true of false in te voeren. Houdt hierbij rekening met verschillende
            //invoermogelijkheden(bijvoorbeeld “true”, “True”, “TRUE”, “T” of “1” voor true).Sla de
            //invoer op in een lijst. Als “stop” wordt ingevoerd moet de invoer stoppen.
            Console.Clear();

            List<bool> invoerLijst = new List<bool>();

            while (true)
            {
                Console.Clear();
                Console.Write("Voer 'true' of 'false' in (of typ 'stop' om te stoppen): ");
                string invoer = Console.ReadLine().ToLower();

                if (invoer == "stop")
                {
                    break;
                }

                bool result;
                if (invoer == "true")
                {
                    result = true;
                }
                else if (invoer == "false")
                {
                    result = false;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
                    Console.WriteLine("Druk op een toets om door te gaan...");
                    Console.ReadKey();
                    continue;
                }

                invoerLijst.Add(result);
            }

            Console.Clear();

            Console.WriteLine("Ingevoerde waarden:");
            foreach (bool invoer in invoerLijst)
            {
                Console.WriteLine(invoer);
            }

            //Tel daarna met een foreach lus hoe vaak true is ingevoerd.
            int trueTeller = 0;
            foreach (bool invoer in invoerLijst)
            {
                if (invoer)
                {
                    trueTeller++;
                }
            }

            Console.WriteLine("Aantal keer 'true' ingevoerd: " + trueTeller);
            Console.ReadKey();

            //Opdracht C - Multidimensionale arrays
            //Breid je Console Applicatie van opdracht B uit met het volgende: Maak een twee
            //dimensionale array van 4 bij 7 groot.Zet hierin de data uit tabel 1 (zie tabel1.png).
            Console.Clear();
            
            int[,] temperatuur = new int[4, 7] {
                 {15, 12, 10, 8, 9, 8, 5} ,
                 {6, 4, -2, -3, -5, -7, -2} ,
                 {0, 1, -2, -4, -3, -8, -9} ,
                 {-11, -8, -5, 2, 4, 5, 1}
            };

            //Laat deze array (netjes) zien in de console en bereken per week de gemiddelde temperatuur.
            for (int i = 0; i < temperatuur.GetLength(0); i++)
            {
                for (int j = 0; j < temperatuur.GetLength(1); j++)
                {
                    Console.Write(temperatuur[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }

            int som = 0;
            int aantalElementen = temperatuur.GetLength(0) * temperatuur.GetLength(1);

            for (int i = 0; i < temperatuur.GetLength(0); i++)
            {
                for (int j = 0; j < temperatuur.GetLength(1); j++)
                {
                    som += temperatuur[i, j];
                }
            }

            double gemiddelde = (double)som / aantalElementen;
            Console.WriteLine("Gemiddelde temperatuur: " + gemiddelde);

            Console.ReadKey();
        }
    }
}
