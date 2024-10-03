using System.Drawing;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var enumerable = NumberSources.GetNumbers(5);

            var enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


            var lista = new List<int>()
            {
                1,2,3,4
            };

            var listb = enumerable.ToList();

            listb.Add(1);
            Console.WriteLine(listb.Count);

            var szam = lista[0];

            var dictionary = new Dictionary<int, string>()
            {
                {1, "asd" },
                {2, "bsd" },
            };

            dictionary.Add(3, "asd");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            var elem = dictionary[1];

            var items = NumberSources.GetNumbers(1).Take2();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            var vector = new Vector<int>(1, 2);
            Console.WriteLine(vector.X);

            var vector2 = new Vector<double>(1.1, 2.1);
            Console.WriteLine(vector2.X);
        }
    }
}
