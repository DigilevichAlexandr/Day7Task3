using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new CustomQueue<string>(new[]
            {
                "one", "two", "three", "four"
            }
            );

            CustomQueue<string>.CustomIterator iterator = queue.Iterator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            iterator.Reset();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            var cueueInt = new CustomQueue<int>(new[]
            {
                1, 2, 3, 4
             });

            CustomQueue<int>.CustomIterator iterator1 = cueueInt.Iterator();

            while (iterator1.MoveNext())
            {
                Console.WriteLine(iterator1.Current);
            }
            iterator1.Reset();
            Console.ReadLine();
        }
        
    }
}
