using System;

namespace BattleRoyaleNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCampeao = 0;
            int firstBlood = 999; 

            Console.WriteLine("Bem-vindo ao Matemática Battle-Royale! Aqui só os maiores números sobrevivem. \nSão permitidos apenas números de 3 dígitos e os números racionais não inteiros banidos!!!");
            for (var i = 0; i < 10; i++)
            {
                int numeroVez = int.Parse(Console.ReadLine());
                
                if (numeroVez > numeroCampeao)
                {
                    numeroCampeao = numeroVez;
                }
                if (numeroVez < firstBlood)
                {
                    firstBlood = numeroVez;
                }
                
            }

            Console.WriteLine("O grande campeão é o " + numeroCampeao + "!!!\nEnquanto isso o menor foi o " + firstBlood + " kkkkkkkk piada.");
        }
    }
}
