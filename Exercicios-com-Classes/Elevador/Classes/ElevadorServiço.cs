using System;
namespace Elevador
{
    public class ElevadorServiço : Elevador
    {
        public int Caixas = 0;
        private int LimiteCaixas = 6;
        public void AlterarCaixas()
        {
            bool Validade = false;
            do
            {
                Console.Write("Qual a nova quantidade de caixas? ");
                Caixas = int.Parse(Console.ReadLine());

                if (Caixas < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido");
                }
                else if (Caixas > LimiteCaixas)
                {
                    Console.Clear();
                    Console.WriteLine("Valor muito alto!");
                }
                else
                {
                    Validade = true;
                }
            } while (Validade == false);
        }
        public override void Entrar()
        {
            if (Capacidade > Ocupacao)
            {
                Ocupacao++;
                Console.WriteLine($"Uma pessoa entrou do elevador. Existem agora {Ocupacao} pessoas(s) no elevador e {Caixas} caixas");
            }
            else
            {
                Console.WriteLine("A ocupação máxima já foi atingida!");
            }

            Console.ReadLine();
            Console.Clear();
        }
        public override void Sair()
        {
            if (0 < Ocupacao)
            {
                Ocupacao--;
                Console.WriteLine($"Uma pessoa saiu do elevador. Existem agora {Ocupacao} pessoas(s) no elevador e {Caixas} caixas");
            }
            else
            {
                Console.WriteLine("Não existem pessoas no elevador!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}