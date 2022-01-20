using System;

namespace MoonwalkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] normalWalk = null;
            normalWalk = new int[15];
            Console.WriteLine("Escreva uma sequência de 15 números: ");

            int c = 0;
            foreach (var item in normalWalk)
            {
                normalWalk[c] = int.Parse(Console.ReadLine());
                c++;
            }
            
            Console.WriteLine("\nAgora igual o MICHAEL.");

            c = 14;
            foreach (var item in normalWalk)
            {
                Console.WriteLine(normalWalk[c]);
                c--;
            }



        }
    }
}
