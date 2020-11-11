using System;
using System.Collections.Generic;
using System.Linq;

namespace Wandio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input Numbers: ");
            var numbers = ConvertMembers(Console.ReadLine());
            ForDefault(numbers);
            Console.WriteLine();
            SecondTest(numbers);
            ////Console.WriteLine();
            //ForNull();

            Console.ReadKey();
        }

        static void ForDefault(IEnumerable<int> numbers, int newRecord = 1)
        {
            var chekNumber = numbers.First();
            var result = numbers.ThisDoesntMakeAnySense(x => x == chekNumber, () => 1);
            Console.WriteLine($"Input:  {string.Join(", ", numbers)}\nNew Record: {newRecord}\nChecking for: {chekNumber}\nResult: {result}");
        }

        static void SecondTest(IEnumerable<int> numbers, int newRecord = 1)
        {
            var chekNumber = numbers.OrderBy(x => x).Last() + 1;
            var result = numbers.ThisDoesntMakeAnySense(x => x == chekNumber, () => 1);
            Console.WriteLine($"Input:  {string.Join(", ", numbers)}\nNew Record: {newRecord}\nChecking for: {chekNumber}\nResult: {result}");

        }

        static void ForNull()
        {
            var result = NoSenseTask.ThisDoesntMakeAnySense(null, x => x == 61, () => 1);

        }
        static IEnumerable<int> ConvertMembers(string text)
        {
            return text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x));
        }
    }
}
