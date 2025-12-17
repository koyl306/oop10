using System;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {
                5, -3, 12, -7, 9, -1, 4, -6, 15, -10,
                8, -2, 11, -9, 6, -4, 14, -8, 3, -5
            };
    
            var positiveNumbers = numbers.Where(n => n > 0);
            var negativeNumbers = numbers.Where(n => n < 0);
            int positiveCount = positiveNumbers.Count();
    
            Console.WriteLine("Додатні числа - ");
            foreach (var n in positiveNumbers)
                Console.Write(n + " ");
    
            Console.WriteLine("\n\nВід’ємні числа - ");
            foreach (var n in negativeNumbers)
                Console.Write(n + " ");
    
            Console.WriteLine($"\n\nКількість додатних чисел - {positiveCount}");
        }
    }
}