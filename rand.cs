using System;
namespace dice
{
    public class Program
    {
        public static Random _random = new Random();
        public static void Main(string[] args)
        {
            //
            int sideDeterminant = _random.Next(2147483646);
            Console.WriteLine(sideDeterminant);
        }
    }
}


