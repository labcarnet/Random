using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var RandomDigit = rand.Next(0,100);
            var inputDigit = 0;
            var counter = 0;
            Console.WriteLine("Witaj w grze. Została wylosowna licza z zakresu 0-100. \nWygrasz jeśli podasz właściwą liczbę całkowitą. ");
            do
            {
                Console.WriteLine("\nWprowadź swój typ z zakresu 0-100 aby sprawdzić czy wygrałeś.");
                inputDigit = GetUserDigit();
                if(inputDigit == RandomDigit)
                {
                    counter++;
                    Console.WriteLine($"\nGratulacje!!! Wygrałeś za {counter} podejściem.");
                    break;
                }
                else if (inputDigit > RandomDigit)
                {
                    Console.WriteLine("\nPrzykro mi. Podana przez Ciebie liczba jest za duża");
                    counter++;
                }
                else
                {
                    Console.WriteLine("\nPrzykro mi. Podana przez Ciebie liczba jest za mała");
                    counter++;
                }
            } while (RandomDigit != inputDigit);

        }

        private static int GetUserDigit()
        {
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userDigit) || userDigit < 0 || userDigit > 100)
                {
                    Console.WriteLine("\nPrzykro mi. Podana przez Ciebie liczba jest niewłaściwa. \nPodaj liczbę z zakresu 0-100");
                    continue;
                }
                return userDigit;
            }
            
        }
    }
}
