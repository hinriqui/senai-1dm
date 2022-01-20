using System;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevadorSocial Social = new ElevadorSocial();
            ElevadorServiço Serviço = new ElevadorServiço();

            Console.Write("Defina a:\nQuantidade de andares - ");
            Social.TotalAndar = int.Parse(Console.ReadLine());
            Serviço.TotalAndar = Social.TotalAndar;

            Console.Write("Capacidade máxima elevador - ");
            Social.Capacidade = int.Parse(Console.ReadLine());
            Serviço.Capacidade = Social.Capacidade;

            Console.Clear();
            bool FimPrograma = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Deseja utilizar o Elevador Social? (s/n)");
                if (Console.ReadLine().ToLower().Substring(0, 1) == "s")
                {
                    bool Validade = false;
                    do
                    {
                        Console.WriteLine($@"
1. Subir
2. Descer
3. Entrar
4. Sair
5. Parar");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Social.Subir();
                                break;

                            case "2":
                                Social.Descer();
                                break;

                            case "3":
                                Social.Entrar();
                                break;

                            case "4":
                                Social.Sair();
                                break;

                            case "5":
                                Validade = true;
                                break;

                            default:
                                Console.WriteLine("Valor inválido");
                                break;
                        }

                    } while (Validade == false);
                }
                Console.Clear();
                Console.WriteLine("Deseja utilizar o Elevador de Serviços? (s/n)");
                if (Console.ReadLine().ToLower().Substring(0, 1) == "s")
                {
                    bool Validade = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($@"
1. Subir
2. Descer
3. Entrar
4. Sair
5. Alterar número caixas
6. Parar");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Serviço.Subir();
                                break;

                            case "2":
                                Serviço.Descer();
                                break;

                            case "3":
                                Serviço.Entrar();
                                break;

                            case "4":
                                Serviço.Sair();
                                break;

                            case "5":
                                Serviço.AlterarCaixas();
                                break;

                            case "6":
                                Validade = true;
                                break;

                            default:
                                Console.WriteLine("Valor inválido");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                    } while (Validade == false);
                }
                Console.Clear();
                Console.WriteLine("Deseja sair do programa? (s/n)");
                if (Console.ReadLine().ToLower().Substring(0, 1) == "s")
                {
                    Console.Clear();
                    FimPrograma = true;
                }
            } while (FimPrograma == false);
        }
    }
}
