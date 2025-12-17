using System;
using System.IO;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("text.txt");

            var words = text.Split(new char[] { ' ', ',', '.', '!', '?', '\n', '\r' },
                                    StringSplitOptions.RemoveEmptyEntries);
    
            var linqWords = words.Where(w => w == "LINQ");
            var queryLanguageWords = words.Where(w => w == "мова запитів");
    
            int linqCount = linqWords.Count();
    
            Console.WriteLine("\n'LINQ' знайдені в тексті -");
            foreach (var w in linqWords)
                Console.Write(w + " ");
    
            Console.WriteLine("\n\n'мова запитів' знайдені в тексті -");
            foreach (var w in queryLanguageWords)
                Console.Write(w + " ");
    
            Console.WriteLine($"\n\nКількість повторень 'LINQ' - {linqCount}");
        }
    }
}