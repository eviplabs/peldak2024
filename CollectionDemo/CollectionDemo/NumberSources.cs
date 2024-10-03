using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class NumberSources
    {
        static public IEnumerable<int> GetNumbers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }

        static public IEnumerable<int> GetPrimes(int count)
        {
            int counter = 0;
            int current = 2;
            while (counter < count)
            {
                if (IsPrime(current))
                {
                    yield return current;
                    counter++;
                }
                current++;
            }
        }

        static public bool IsPrime(int i)
        {
            bool isPrime = true;

            if (i == 1 || i == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }
    }
}
