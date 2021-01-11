using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex5_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("*** FASE 1 ***");

            //creació de l'array
            int[] numbers = new int[] {2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};

            //consulta LINQ
            IEnumerable<int> evenNumbers = from num in numbers where (num % 2 == 0) select num;

            //mostra l'array per pantalla
            Console.WriteLine("- Aquests són els números parells:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("*** FASE 2 ***");

            var avg = numbers.Average();
            var max = numbers.Max();
            var min = numbers.Min();

            Console.WriteLine($"- La nota mitjana és de {avg}, la màxima és de {max} i la mínima és de {min}.");

            Console.WriteLine();
            Console.WriteLine("*** FASE 3 ***");

            //LINQ queries
            var higherThanFive = from num in numbers where num > 5 select num;
            var lowerThanFive = from num in numbers where num < 5 select num;

            //mostra per pantalla
            Console.WriteLine($"- Els números més grans de 5 són:");
            foreach (var num in higherThanFive)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine($"- Els números més petits de 5 són:");
            foreach (var num in lowerThanFive)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("*** FASE 4 ***");

            //creació de l'array
            string[] Names = new string[] {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"};

            //consultes LINQ
            var startsWithO = from s in Names where s.StartsWith("O") select s;

            Console.WriteLine("- Aquests són els noms que comencen amb la lletra 'O':");
            
            foreach (var s in startsWithO)
            {
                Console.WriteLine(s);
            }
            
            //------------------------------------------------

            var moreThanFive = from m in Names where m.Length > 5 select m;

            Console.WriteLine();
            Console.WriteLine("- Aquests són els noms que tenen més de 5 lletres:");
            
            foreach (var m in moreThanFive)
            {
                Console.WriteLine(m);
            }

            //------------------------------------------------
            
            var desc = from d in Names orderby d descending select d;
            
            Console.WriteLine();
            Console.WriteLine("- Aquests són els noms ordenats de manera descendent:");
            
            foreach (var item in desc)
            {
                Console.WriteLine(item);
            }
        }
    }
}