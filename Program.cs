using System;
using System.Collections.Generic;

namespace DOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in GenerateWithYield())
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        public static IEnumerable<int> GenerateWithoutYield()
        {
            var i = 0;
            var list = new List<int>();
            while (i < 5)
                list.Add(++i);
            return list;
        }

        public static IEnumerable<int> GenerateWithYield()
        {
            var i = 0;
            while (i < 5)
                yield return ++i;
        }
    }
}
