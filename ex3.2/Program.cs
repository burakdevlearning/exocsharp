using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>
            {
                2000,2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020
            };

            var request = (from bix in years
                           where (new DateTime(bix, 12, 31).DayOfYear == 366)
                           select bix);

            int nbValues = request.Count();

            if (nbValues == 0)
                Console.WriteLine("Aucune année bisextile dans la liste");
            else
            {
                List<int> bisextile = request.ToList();
                Console.WriteLine("Les années bisextiles contenues dans la liste");
                foreach (int b in bisextile)
                    Console.WriteLine(b);
            }
        }
    }
}
