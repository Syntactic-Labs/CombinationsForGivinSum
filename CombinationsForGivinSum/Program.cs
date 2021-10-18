using System;
using System.Collections.Generic;

namespace CombinationsForGivinSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 9, 8, 4, 5, 7, 10 };
            int total = 15;
            Sum(numbers, total);
        }

        private static void Sum(List<int> numbers, int total)
        {
            Sum2(numbers, total, new List<int>());
        }

        private static void Sum2(List<int> numbers, int total, List<int> partial)       //("(" + string.Join(",", partial.ToArray()) + ")=" + total)
        {
            int s = 0;
            foreach (int x in partial) s += x;

            if (s == total)
                Console.WriteLine("(" + string.Join(",", partial.ToArray()) + ")=" + total);
                //Console.WriteLine($");

            if (s >= total)
                return;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> remaining = new List<int>();
                int n = numbers[i];
                for (int j = i + 1; j < numbers.Count; j++) remaining.Add(numbers[j]);

                List<int> partial_rec = new List<int>(partial);
                partial_rec.Add(n);
                Sum2(remaining, total, partial_rec);
            }
        }
    }
}
