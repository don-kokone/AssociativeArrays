using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resoursec = new Dictionary<string, int>();

            string resource = string.Empty;

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resoursec.ContainsKey(resource))
                {
                    resoursec[resource] = quantity;
                }
                else
                {
                    resoursec[resource] = resoursec[resource] + quantity;
                }
            }

            foreach (var kvp in resoursec)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
