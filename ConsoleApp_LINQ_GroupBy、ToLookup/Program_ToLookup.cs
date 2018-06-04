using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_LINQ_GroupBy_ToLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameValuesGroup = new[]
            {
              new { name = "allen", value = 65, group= "a" },
              new { name = "abbey", value = 120, group= "a" },
              new { name = "slong", value = 330, group= "b" },
              new { name = "george", value = 213, group= "c" },
              new { name = "meller", value = 329, group= "c" },
              new { name = "mary", value = 192, group= "b" },
              new { name = "sue", value = 200, group= "c" },
          };
            var lookupValues = nameValuesGroup.ToLookup(c => c.group);

            foreach( var g in lookupValues)
            {
                Console.WriteLine($"=== Group ： {g.Key} ===");
                foreach( var item in g)
                {
                    Console.WriteLine($"name： {item.name}, value： {item.value}");
                }
            }

            Console.Read();
        }                
    }
}
