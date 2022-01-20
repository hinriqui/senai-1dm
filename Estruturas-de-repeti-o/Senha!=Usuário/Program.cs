using System;

namespace Senha__Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validade = false;
            do
            {
                Console.WriteLine("Nome de usuário: ");
                string nomeUsuario = Console.ReadLine();

                Console.WriteLine("Senha: ");
                string senha = Console.ReadLine();

                if (nomeUsuario == senha)
                {
                    Console.WriteLine("Erro. Usúario e senha precisam ser diferentes.");
                }
                else
                {
                    validade = true;
                }
            } while (validade == false);


        }
    }
}
