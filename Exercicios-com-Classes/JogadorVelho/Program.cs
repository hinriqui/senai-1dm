using System;
using JogadorVelho.Classes;

namespace JogadorVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j = new Jogador();
            Atacante a = new Atacante();
            Meia m = new Meia();
            Defensor d = new Defensor();

            Console.Write("Digite o nome do jogador: ");
            j.Nome = Console.ReadLine();

            Console.Write("Digite o ano de nascimento: ");
            j.AnoNasc = int.Parse(Console.ReadLine());

            Console.Write("Digite a nacionalidade do jogador: ");
            j.Naçao = Console.ReadLine();

            Console.Write("Digite a altura do jogador: ");
            j.Altura = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso do jogador: ");
            j.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"Presumimos que o {j.Nome} tenha hoje cerca de {j.idade()} anos. Qual a posição do jogador? (ataque, meio ou defesa?)");

            switch (Console.ReadLine().ToLower().Substring(0, 1))
            {
                case "a":
                    if ((a.Aposentadoria - j.Idade) > 0)
                    {
                        Console.WriteLine($"Com base nisso, estimasse que o {j.Nome} irá se aposentar em cerca de {a.Aposentadoria.ToString()} anos!");
                    }
                    else
                    {
                        Console.WriteLine("Parece que ele se aposentará em breve...");
                    }

                    break;

                case "m":
                    if ((m.Aposentadoria - j.Idade) > 0)
                    {
                        Console.WriteLine($"Com base nisso, estimasse que o {j.Nome} irá se aposentar em cerca de {m.Aposentadoria.ToString()} anos!");
                    }
                    else
                    {
                        Console.WriteLine("Parece que ele se aposentará em breve...");
                    }
                    break;

                case "d":
                    if ((d.Aposentadoria - j.Idade) > 0)
                    {
                        Console.WriteLine($"Com base nisso, estimasse que o {j.Nome} irá se aposentar em cerca de {d.Aposentadoria.ToString()} anos!");
                    }
                    else
                    {
                        Console.WriteLine("Parece que ele se aposentará em breve...");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
