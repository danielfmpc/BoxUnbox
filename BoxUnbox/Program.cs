using System;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boxing!!");
            int x = 20;
            Object obj = x;
            Console.WriteLine(obj);

            Console.WriteLine("UnBoxing!!");
            x = 20;
            int y = (int) obj;

        }
    }
}
