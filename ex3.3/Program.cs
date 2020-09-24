using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers2 = new List<int>
            {
                2,5,7,8,10,11,13,15,22,25,26,30,42,45,55,60,128,130
            };

            List<int> byfive = numbers2.Where(n => n % 5 == 0).ToList();
            foreach (int f in byfive)
                Console.WriteLine(f);
        }
    }
}
