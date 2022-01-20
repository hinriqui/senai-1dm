using System;

namespace EncontradorPai
{
    class Program
    {
        static void Main(string[] args)
        {
            bool achou = false; 
            string[] possiveisPais = null;
            possiveisPais = new string[9];

            Console.WriteLine("Fale o nome de 10 pessoas.");

            int c = 0;
            foreach (var item in possiveisPais)
            {
                possiveisPais[c] = Console.ReadLine();
                c++;
            }

            Console.WriteLine("Agora, fale o nome do seu pai.");
            string seuPai = Console.ReadLine();
            
            c = 0;
            
            foreach (var item in possiveisPais)
            {   
                if (seuPai == possiveisPais[c])
                {
                    achou = true;
                }
            }

            if (achou == true)
            {
                Console.WriteLine("Parabéns! Pai encontrado!");
            }
            else
            {
                Console.WriteLine("É kkkk... Então kkk... Achei não.");
            }

        }
    }
}
