using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarieren und Initialisieren eines Arrays
            int[] schulNoten = new int[5];  //erstmal 5 leere Werte
            // C# beginnt das Zählen bei 0
            // ArrayName[index] = Wert der zugewiesen werden soll
            schulNoten[0] = 3;
            schulNoten[1] = 2;
            schulNoten[2] = 4;
            schulNoten[3] = 1;
            schulNoten[4] = 1;
            //alle Werte zugewiesen.[5] von 0 bis 4.


            // Aufpassen bei der Größe/Länge des Arrays
            // FALSCH: schulNoten[5] = 2; - da der Array nur 5 Werte beinhalten kann.


            // Zugreifen auf einen Wert im Array
            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);

            string input = Console.ReadLine();
            schulNoten[0] = int.Parse(input);
            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);

            // weiterer Weg Arrays anzulegen
            int[] schulNotenVonMatheStudenten = { 1, 3, 2, 2, 5, 4, 4, 3 };

            // weiterer Weg Arrays anzulegen
            int[] schulNotenVonDeutschStudenten = new int[] { 1, 3, 2, 2, 3, 2, 2, 2, 5, 6 };
            Console.WriteLine("Länge des Arrays: {0}", schulNotenVonDeutschStudenten.Length);

            Console.ReadKey();
        }
    }
}
