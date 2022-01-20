using System;
namespace Elevador
{
    public abstract class Elevador
    {
        public int TotalAndar = 6;
        public int Andar = 0;
        public int Capacidade = 6;
        public int Ocupacao = 0;
        virtual public void Entrar()
        {
            if (Capacidade > Ocupacao)
            {
                Ocupacao++;
                Console.WriteLine($"Uma pessoa entrou do elevador. Existem agora {Ocupacao} pessoas(s) no elevador");
            }
            else
            {
                Console.WriteLine("A ocupação máxima já foi atingida!");
            }

            Console.ReadLine();
            Console.Clear();
        }
        virtual public void Sair()
        {
            if (0 < Ocupacao)
            {
                Ocupacao--;
                Console.WriteLine($"Uma pessoa saiu do elevador. Existem agora {Ocupacao} pessoas(s) no elevador");
            }
            else
            {
                Console.WriteLine("Não existem pessoas no elevador!");
            }

            Console.ReadLine();
            Console.Clear();
        }
        public void Subir()
        {
            if (TotalAndar > Andar)
            {
                Andar++;
                Console.WriteLine($"O elevador subiu um andar. Estamos agora no nível {Andar}");
            }
            else
            {
                Console.WriteLine("Estamos no último andar!");
            }

            Console.ReadLine();
            Console.Clear();
        }
        public void Descer()
        {
            if (0 < Andar)
            {
                Andar--;
                Console.WriteLine($"O elevador desceu um andar. Estamos agora no nível {Andar}");
            }
            else
            {
                Console.WriteLine("Estamos no térreo!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}