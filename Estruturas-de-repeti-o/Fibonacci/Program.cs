using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pega essa fibonacci.\n");

            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.WriteLine(n1 + "\n" + n2);

            do
            {
                n3 = n2 + n1;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            } while (n3 <= 500);
        }
    }
}
