using System;

namespace KingTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salve menó, segura essa king tabuada aqui.");

            for (int a = 0; a <= 10; a++)
            {
                Console.WriteLine("Tabuada do " + a + "\n");
                for (var b = 1; b <= 10; b++)
                {
                    Console.WriteLine(a + " × " + b + " = " + (a*b));
                }
            }
        }
    }
}
