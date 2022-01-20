using System;

namespace AjusteSalário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu salário:");
            double salario = float.Parse(Console.ReadLine());
            if (salario < 500)
            {
                double salarioAumento = salario * 1.3;
                Console.WriteLine("Seu salário será reajustado para " + salarioAumento + " reais.");
            } else {
                Console.WriteLine("Seu salário não sofrerá reajuste.");
            }
        }
    }
}
