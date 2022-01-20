using System;

namespace CelularObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool final = false;
            while (final == false)
            {
                Celular celular = new Celular();

                Console.Write("Cor: ");
                celular.cor = Console.ReadLine();

                Console.Write("Modelo: ");
                celular.modelo = Console.ReadLine();

                Console.Write("Polegadas: ");
                celular.tamanho = float.Parse(Console.ReadLine());

                celular.comprado = true;


                while (celular.comprado == true)
                {
                    if (celular.ligado == false)
                    {
                        Console.Clear();
                        Colorir(celular.cor);
                        Console.WriteLine($@"
                               .:::::::::::::::::::::::::::::::::::::::::::::::::::::::.                                
                          !@@.                                                            :@@:                          
                        :@:                                                                  @@:                        
                        @@                                                                   .@@                        
                        @@                                                                   .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@                                .#!.                               .@@                        
                        @@                            #@:     .@#                            .@@                        
                        !@:                           !@#     !@!                            @@:                        
                          #@@.                                                            :@@!                          
                               .::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.ResetColor();
                        Console.WriteLine("Deseja ligar o celular? (S/N)");

                        if (Console.ReadLine().Substring(0, 1).ToLower() == "s")
                        {
                            celular.ligado = true;
                        }
                        else
                        {
                            Console.Clear();
                            final = true;
                            celular.comprado = false;
                        }

                        Console.Clear();

                    }
                    else
                    {
                        Colorir(celular.cor);
                        Console.WriteLine($@"                                                                                                                        
                               .:::::::::::::::::::::::::::::::::::::::::::::::::::::::.                                
                          !@@.                                                            :@@:                          
                        :@:                                                                  @@:                        
                        @@                                                                   .@@                        
                        @@                                                                   .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:               0. Comprar um celular novo                 !@. .@@                        
                        @@  :@:                  1. Desligar celular                     !@. .@@                        
                        @@  :@:                    2. Fazer ligação                      !@. .@@                        
                        @@  :@:                   3. Mandar mensagem                     !@. .@@                        
                        @@  :@:                   4. Sobre o celular                     !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@                                .#!.                               .@@                        
                        @@                            #@:     .@#                            .@@                        
                        !@:                           !@#     !@!                            @@:                        
                          #@@.                                                            :@@!                          
                               .::::::::::::::::::::::::::::::::::::::::::::::::::::::::                                ");
                        Console.ResetColor();

                        switch (Console.ReadLine())
                        {
                            case "1":
                                celular.ligado = false;
                                Console.Clear();
                                break;

                            case "2":
                                Console.Clear();
                                Colorir(celular.cor);
                                Console.WriteLine($@"
                               .:::::::::::::::::::::::::::::::::::::::::::::::::::::::.                                
                          !@@.                                                            :@@:                          
                        :@:                                                                  @@:                        
                        @@                                                                   .@@                        
                        @@                                                                   .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                        gOdirlei                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                       Chamando...                        !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@                                .#!.                               .@@                        
                        @@                            #@:     .@#                            .@@                        
                        !@:                           !@#     !@!                            @@:                        
                          #@@.                                                            :@@!                          
                               .::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                                Console.ResetColor();
                                Console.Write("Pressione ENTER para sair.");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                Console.Clear();
                                Colorir(celular.cor);
                                Console.WriteLine($@"
                               .:::::::::::::::::::::::::::::::::::::::::::::::::::::::.                                
                          !@@.                                                            :@@:                          
                        :@:                                                                  @@:                        
                        @@                                                                   .@@                        
                        @@                                                                   .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:       gOdirlei tem muitas coisas pra desenvolver,        !@. .@@                        
                        @@  :@: você não pode interrompe-lo por causa de um exercício... !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@                                .#!.                               .@@                        
                        @@                            #@:     .@#                            .@@                        
                        !@:                           !@#     !@!                            @@:                        
                          #@@.                                                            :@@!                          
                               .::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                                Console.ResetColor();
                                Console.Write("Pressione ENTER para sair.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            
                            case "4":
                                Console.Clear();
                                Colorir(celular.cor);
                                Console.WriteLine($@"
                               .:::::::::::::::::::::::::::::::::::::::::::::::::::::::.                                
                          !@@.                                                            :@@:                          
                        :@:                                                                  @@:                        
                        @@                                                                   .@@                        
                        @@                                                                   .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:               Cor:       {celular.cor}                                                                          
                        @@  :@:               Modelo:    {celular.modelo}                                                                            
                        @@  :@:               Resolução: {celular.tamanho}''                                                                              
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@  :@:                                                          !@. .@@                        
                        @@                                .#!.                               .@@                        
                        @@                            #@:     .@#                            .@@                        
                        !@:                           !@#     !@!                            @@:                        
                          #@@.                                                            :@@!                          
                               .::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                                Console.ResetColor();
                                Console.Write("Pressione ENTER para sair.");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "0":
                                Console.Clear();
                                celular.comprado = false;
                                break;
                            default:
                                Console.Clear();
                                break;
                        }

                    }
                }
            }
        }


        static void Colorir(string variavel)
        {
            switch (variavel.Substring(0, 1).ToLower())
            {
                case "v":
                    Console.ForegroundColor = ConsoleColor.Red;
                    variavel = "Vermelho";
                    break;
                case "a":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    variavel = "Azul";
                    break;
                case "p":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    variavel = "Cinza";
                    break;
                case "b":
                    Console.ForegroundColor = ConsoleColor.White;
                    variavel = "Branco";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    variavel = "Indefinida";
                    break;
            }
        }
    }
}