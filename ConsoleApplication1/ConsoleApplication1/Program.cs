using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();
            int check = 0;
            bool[] goodQueueBool = new bool[] { false, false, false, true, false, false, false };
            foreach (bool element in goodQueueBool)
            {
                if(element) System.Console.WriteLine(element);
            }
            System.Console.ReadKey();
        }
    }
}
