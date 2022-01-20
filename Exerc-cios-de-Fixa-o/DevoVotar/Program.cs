using System;

namespace ExercíciosFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saudações! Em que ano estamos? ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Interessante... E em qual ano você nasceu? ");
            int anoNasc = int.Parse(Console.ReadLine());

            int suaIdade = anoAtual - anoNasc;
            if (suaIdade > 17)
            {
                Console.WriteLine("Parece que alguém vai precisar votar esse ano.");
            }
            else
            {
                if (suaIdade > 15)
                {
                    Console.WriteLine("Parece que alguém vai poder votar esse ano.");
                }
                else
                {
                    Console.WriteLine("Parece que alguém ainda não pode votar.");
                }
            }

        }
    }
}
