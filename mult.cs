using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Reflection;
namespace tetris
{
    public class Program
    {
        public static int Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            string inA = Console.ReadLine();
            string inB = Console.ReadLine();
            
            bool result1 = int.TryParse(inA, out a);
            bool result2 = int.TryParse(inB, out b);
            if (!result1 || !result2)
            {
                Console.WriteLine("invalid entry");
                return 0;
            }
            else if (result1 && result2)
            {
                while (b != 0)
                {
                    c = c + a;
                    b = b - 1;
                }
                Console.WriteLine(c);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

