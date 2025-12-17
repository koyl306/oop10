using System;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 12, 15, 18, 17, 18, 28 };

            int sum = numbers.Sum();
            Console.WriteLine($"Сума чисел - {sum}");
    
            int difference = numbers.Skip(1).Aggregate(numbers[0], (acc, n) => acc - n);
            Console.WriteLine($"Різниця чисел - {difference}");
        }
    }
}