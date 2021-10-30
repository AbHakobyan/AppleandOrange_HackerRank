using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleandOrange_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            List<int> p = new List<int>();  
            List<int> o = new List<int>();
            int count = 0;
            int countr = 0;
            for (int i = 0; i < apples.Count; i++)
            {
                int x = a + apples[i];
                p.Add(x);
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                int x = b + oranges[i];
                o.Add(x);
            }
            foreach (var item in p)
            {
                if (item > s && item < t)
                {
                    count++;
                }
            }
            foreach (var item in o)
            {
                if (item > s && item < t)
                {
                    countr++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(countr);
        }
    }
}
