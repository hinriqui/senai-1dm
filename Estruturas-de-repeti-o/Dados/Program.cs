using System;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validade = false;
            string nome;
            int idade;
            float salario;
            string estadoCivil;


            do
            {
                Console.Write("Nome : ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Console.WriteLine("Valor válido");
                    validade = true;
                }
            }
            while (validade == false);
            validade = false;

            do
            {
                Console.Write("Idade : ");
                idade = int.Parse(Console.ReadLine());
                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Console.WriteLine("Valor válido");
                    validade = true;
                }
            }
            while (validade == false);
            validade = false;

            do
            {
                Console.Write("Salário : ");
                salario = float.Parse(Console.ReadLine());
                if (salario <= 0)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    Console.WriteLine("Valor válido");
                    validade = true;
                }
            }
            while (validade == false);
            validade = false;

            do
            {
                Console.Write("Estado civil : ");
                estadoCivil = Console.ReadLine().ToLower().Substring(0, 1);

                switch (estadoCivil)
                {
                    case "c":
                        estadoCivil = "Casado(a)";
                        Console.WriteLine("Valor válido");
                        validade = true;
                        break;
                        
                    case "s":
                        estadoCivil = "Solteiro(a)";
                        Console.WriteLine("Valor válido");
                        validade = true;
                        break;
                        
                    case "v":
                        estadoCivil = "Viúvo(a)";
                        Console.WriteLine("Valor válido");
                        validade = true;
                        break;
                        
                    case "d":
                        estadoCivil = "Divorciado(a)";
                        Console.WriteLine("Valor válido");
                        validade = true;
                        break;
                        
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }
            while (validade == false);

            Console.WriteLine("\nNome: " + nome + "\nIdade: " + idade + "\nSalário: R$ " + salario + "\nEstado Civil: " + estadoCivil);
        }
    }
}
