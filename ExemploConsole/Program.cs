using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("ATIVIDADE DE MÉDIA\n");
            Console.WriteLine("Bem vindo. Qual o seu nome?");
            string nomePessoa = Console.ReadLine();
            Console.Write("Buongiorno " + nomePessoa + "!");
            Console.WriteLine(" Qual a primeira nota?");
            float primeiraNota = int.Parse(Console.ReadLine());
            Console.WriteLine("Certo, agora a segunda.");
            float segundaNota = int.Parse(Console.ReadLine());
            Console.WriteLine("A última.");
            float terceiraNota = int.Parse(Console.ReadLine());
            float mediaNotas = (primeiraNota + segundaNota + terceiraNota) / 3;
            
            if (mediaNotas > 5)
            {
                Console.WriteLine("Boa, você ficou com uma média de " + mediaNotas.ToString("N2") + ". Ganhou um pão de queijo.");
            } else {
                Console.WriteLine("Você ficou com uma média de " + mediaNotas.ToString("N2") + ". Te falta pão de queijo.");
            }
        }
    }
}
