using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp
{
    class Program
    {
        static void Main()
        {
            string[] words = new string[3];

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"N{i} word: ");
                words[i] = Console.ReadLine();
            }

            Console.Write($"Roses are {words[0]}\n{words[1]}s are blue\nI love {words[2]}\n");
        }
    }
}