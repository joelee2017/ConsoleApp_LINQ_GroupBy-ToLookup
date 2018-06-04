using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_LINQ_GroupBy_ToLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequences = new List<int>() { 1, 2, 4, 3, 2, 4, 6, 4, 5, 2, 2, 6, 3, 5, 7, 5 };

            var qroup = sequences.GroupBy(o => o);

            foreach ( var  q in qroup)
            {
                Console.WriteLine($" {q.Key}  count： {q.Count()}");
            }
            Console.ReadLine();
        }
    }
}
