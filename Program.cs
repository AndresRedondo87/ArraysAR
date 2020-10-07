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
                nums[i] = i + 10;
            }

            int counter = 0;
            foreach (var item in nums)
            {
                Console.WriteLine($"Element {counter++} ist: {item}");
            }


            double summe = 0;
            double[] zahlen = new double[] { 5.298, 6.589, 958.5, 4646.8, 9.9, 6.589, 958.5, 4646.8, 9.9, 6.589, 958.5, 4646.8, 9.9, 6.589, 958.5, 4646.8, 9.9 };
            foreach (double nummer in zahlen)
            {
                summe = summe + nummer;
                //Console.WriteLine(summe);
            }
            Console.WriteLine($"Total Summe:{summe}");

            // erstelle einen Array mit 5 deiner besten Freunde (die Namen)
            // erstelle einen Foreach Loop um sie alle zu grüßen

            string[] amigos = new string[] { "andres", "Pepe", "Federico", "Otroamigo", "Quintoamigo" };
            foreach (string name in amigos)
            {
                Console.WriteLine($"Hey, hola {name}!");
            }


            //-------------------------------------------------------------------------------foreach loops


            //---------------------------------------------------------------------------------Multidimensionale Arrays 

            {
                Console.WriteLine();
                Console.WriteLine("-----Multidimensionale Arrays: ");
                // Deklarieren eines 2D Arrays
                string[,] matrix;

                // 3D Array
                int[,,] threeD;

                //Arrays mit 2d sind sowieso Matrix formig. Mit 3D wäre es wie zB. 3x3x3 ein Rubik Cube
                int[,] array2D = new int[,]
                {
                {1,2,3}, // Zeile 0
                {4,5,6}, // Zeile 1
                {7,8,9}  // Zeile 2
                };
                //Andere darstellung aber auch gültig(nicht so überschaubar
                //{{ 1,2,3}, { 4,5,6}, { 7,8,9}};

                //5 ist position 1,1
                Console.WriteLine($"Mittlerer Wert ist {array2D[1, 1]}");
                Console.WriteLine($"Position mit 7 Wertdrinnen enthält {array2D[2, 1]}");
                Console.WriteLine($"Position mit 9 Wertdrinnen enthält {array2D[2, 2]}");

                //Mit 3D wäre es wie zB. 3x3x3 ein Rubik Cube
                string[,,] array3D = new string[,,]
                {
                    {
                        {"000", "001"},
                        {"010", "011"},
                        {"Hi, Wie gehts", "Was geht ab?"},
                        {"aaaaaa", "bbbbbb"}
                    },
                    {
                        {"100", "101"},
                        {"110", "111"},
                        {"Noch mehr", "Denis"},
                        {"ccccccc", "dddddd"}
                    }
                };
                //Beim erweitern müssen alle die gleiche Ordnung haben, gleiche dimensionen von Arrays so zu sagen.
                
                //Hiermit könnte man die Größe schon festlegen um fehlern beim erweitern oder verkleinern zu vermeiden!!
                //string[,,] array3D = new string[2,4,2] 2 "höhen"(aufgestapelten Matrix-Blättern), 4 Zeilen und 2 einträge fur jede Zeile


                //Bestätigen ob ich die Positionen richtig erkennen kann. Bool für true/false
                bool condition = false;
                Console.WriteLine($"\nWert 100 ist bei {array3D[1,0,0]}, richtig?  {condition = array3D[1,0,0] =="100"}");
                Console.WriteLine($"Wert 011 ist bei {array3D[0, 1, 1]}, richtig?  {condition = array3D[0, 1, 1] == "011"}");
                Console.WriteLine($"Wert Denis ist bei {array3D[1, 2, 1]}, richtig?  {condition = array3D[1, 2, 1] == "Denis"}");
                Console.WriteLine($"Wert ccccccc ist bei {array3D[1, 3, 0]}, richtig?  {condition = array3D[1, 3, 0] == "ccccccc"}");
                Console.WriteLine($"Wert Hi, Wie gehts ist bei {array3D[0, 2, 0]}, richtig?  {condition = array3D[0, 2, 0] == "Hi, Wie gehts"}\n");





                // Deklarieren eines 2D Arrays mit Initilisierung
                // direkt 3 reihen mit 2 spalten, festgelegt für immer, darf nicht erweitert werden
                // damit darf es auch ohne initialisieren den Array definieren, da die Größe schon festgelegt worden ist.
                // sonst ist es nicht erlaubt da der Compiler weiß nicht, wie groß das ding sein soll
                //string[,,] array3Dnochein = new string[,,];//arraygröße erforderlich

                //string[,] array2DString = new String[3, 2]; //das von allein würde gehen.
                string[,] array2DString = new String[3, 2]     
                {
                {"eins", "zwei"},
                {"drei", "vier"},
                {"fünf", "sechs"}
                };

                // Überschreiben von Werten in einem Array2D
                Console.WriteLine("Heute gibt es {0}", array2DString[1, 1]);
                Console.WriteLine("Dieses wert vier wird überschrieben, korrigiert");
                array2DString[1, 1] = "Hähnchen!";


                Console.WriteLine("Heute gibt es {0}", array2DString[1, 1]);


                // Rank = nummer der Dimensionen
                Console.WriteLine("Anzahl der Dimensionen {0}", array2DString.Rank);
                // weitere Properties nicht erklärt worden...
                Console.WriteLine("Is fixed Size {0}", array2DString.IsFixedSize);
                Console.WriteLine("Array length {0}", array2DString.Length);    //gesamtzahl in alle dimensionen
                Console.WriteLine("Array read only {0}", array2DString.IsReadOnly);
                Console.WriteLine("Array Sync {0}", array2DString.IsSynchronized);

                Console.WriteLine();
                Console.WriteLine("3D Anzahl der Dimensionen {0}", array3D.Rank); //3, 3 dimensionen
                Console.WriteLine("3DArray length {0}", array3D.Length);
                //2*4*2 = 16 elemente, richtig
            }
            //---------------------------------------------------------------------------------Multidimensionale Arrays Ende




            Console.ReadKey();
        }
    }
}
