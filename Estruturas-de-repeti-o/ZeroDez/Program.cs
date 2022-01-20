using System;

namespace ZeroDez
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool resposta = false;
            do
            {
                Console.WriteLine("Digite um número de 0 a 10!");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 10 && numero >= 0)
                {
                    resposta = true;
                } else
                {
                   resposta = false; 
                }

            } while (resposta == false);
            Console.WriteLine("Programa Finalizado.");

        }
    }
}
