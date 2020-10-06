using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
            // FALSCH: schulNoten[5] = 2; - da der Array nur 5 Werte beinhalten kann. INDEX OUT OF RANGE


            // Zugreifen auf einen Wert im Array
            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);

            // Überschreiben ein Wert im Array
            Console.WriteLine("Neuer Wert für erste Note überschreiben:");
            string input = Console.ReadLine();
            schulNoten[0] = int.Parse(input);
            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);


            // weiterer Weg Arrays anzulegen (schon vorhandenen ints)
            int[] schulNotenVonMatheStudenten = { 1, 3, 2, 2, 5, 4, 4, 3 };

            Console.WriteLine("Länge des Arrays schulNotenVonMatheStudenten: {0}", schulNotenVonMatheStudenten.Length);

            // weiterer Weg Arrays anzulegen (aus neue Klasse, bzw unseren Klassen könnte man verwenden)
            int[] schulNotenVonDeutschStudenten = new int[] { 1, 3, 2, 2, 3, 2, 2, 2, 5, 6 };

            // Eigenschaften von Arrays, zB. Länge:
            Console.WriteLine("Länge des Arrays schulNotenVonDeutschStudenten: {0}", schulNotenVonDeutschStudenten.Length);




            //-------------------------------------------------------------------------------foreach loops


            string[] friends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(friends[i]);  //IndexOutOfRangeException!! Um sowas zu vvermeiden...
            //}

            //einfach bis die ganze Länge laufen lassen....
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);  //IndexOutOfRangeException!!
            }
            Console.WriteLine($"friends.Length ist: {friends.Length}");


            //Oder/ABER am Besten FOREACH, einfachere schreibweise und nutzliche Name dingens
            // der Name dürfen wir selber entscheiden und damit arbeiten!!
            // in foreach schuaen wir auch was für inhalt daraus wir kriegen wollen. 
            foreach (string name in friends)
            {
                Console.WriteLine("Hallo {0}, mein Freund", name);
            }
            Console.WriteLine();

            int[] nums = new int[15];

            //ausfüllen
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]=i+10; 
            }

            int counter = 0;
            foreach (var item in nums)
            {
                Console.WriteLine($"Element {counter++} ist: {item}");
            }


            double summe = 0;
            double[] zahlen = new double[] {5.298 , 6.589 , 958.5 , 4646.8, 9.9 , 6.589, 958.5, 4646.8, 9.9 , 6.589, 958.5, 4646.8, 9.9 , 6.589, 958.5, 4646.8, 9.9 };
            foreach (double nummer in zahlen)
            {
                summe = summe + nummer;
                //Console.WriteLine(summe);
            }
            Console.WriteLine($"Total Summe:{summe}");

            // erstelle einen Array mit 5 deiner besten Freunde (die Namen)
            // erstelle einen Foreach Loop um sie alle zu grüßen

            string[] amigos = new string[] { "andres", "Pepe", "Federico", "Otroamigo", "Quintoamigo"};
            foreach (string  name in amigos)
            {
                Console.WriteLine($"Hey, hola {name}!");
            }


            //-------------------------------------------------------------------------------foreach loops

            Console.ReadKey();
        }
    }
}
