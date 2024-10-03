using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal static class ExtensionMethods
    {
        public static IEnumerable<int> Take2(this IEnumerable<int> source)
        {
            int counter = 0;
            foreach (var item in source)
            {
                if (counter < 2)
                {
                    yield return item;
                }
                counter++;
            }
        }
    }
}
