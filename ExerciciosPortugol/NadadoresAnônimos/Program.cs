using System;

namespace NadadoresAnônimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você têm?");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 17)
            {
                Console.WriteLine("Categoria Senior");
            }else {
                if (idade > 13)
                {
                    Console.WriteLine("Juvenil B");
                }else {
                    if (idade > 10)
                    {
                        Console.WriteLine("Juvenil A");
                    }else {
                        if (idade > 7)
                        {
                            Console.WriteLine("Infantil B");
                        }else {
                            if (idade > 4)
                            {
                                Console.WriteLine("Infantil A");
                            }else {
                                Console.WriteLine("Infelizmente só temos cursos a partir de 5 anos...");
                            }                            
                        }
                    }
                }
            }

        }
    }
}
