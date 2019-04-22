using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string arr = Console.ReadLine();
            //char[] nums = arr.ToCharArray();
            char[] nums = Console.ReadLine().Where(x => x != ' ').ToArray();


            var counts = new Dictionary<char, int>();

            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
