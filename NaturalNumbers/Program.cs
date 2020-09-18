using System;
using System.Collections;
using System.Collections.Generic;

namespace NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> someDataStream = BuildNaturalStream();
            foreach(int natural in someDataStream)
            {
                Console.WriteLine(natural);
            }

        }
        private static IEnumerable<int> BuildNaturalStream()
        {
            List<int> natural = new List<int>();
            for(int i=0;i<=500;i++){
                natural.Add(i);
            }
            return natural;
        }

        private static Func<int> BuildCounter()
        {
            int i = 0;
            return () => i++;
        }
    }
    
}
