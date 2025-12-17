using System;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            var selectedNumbers = numbers.Skip(2).Take(3);
    
            Console.WriteLine("Вибрані числа -");
            foreach (var n in selectedNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}