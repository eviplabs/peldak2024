using System;
using System.Collections.Generic;

namespace YieldReturnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var j in GetNumbers())
                Console.WriteLine(j);
        }

        static IEnumerable<int> GetNumbers()
        {
            for (int i = 0; i < 5; i++)
                yield return i;
        }
    }
}
