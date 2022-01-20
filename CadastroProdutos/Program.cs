using System;

namespace ProjetoFeira
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int tamanhoLista = 10;
            int c = 0;

            string[] nomesProdutos = new string[10];
            float[] preçoProdutos = new float[10];
            string[] promoProdutos = new string[10];

            do
            {
                Console.WriteLine("\nBem vindo ao gerenciador de produtos! Sua lista possui um tamanho de " + tamanhoLista + " produtos.");
                Console.WriteLine($@"
==============================
|           Opções:          |
|   1 - Cadastrar produtos   |
|     2 - Listar produtos    |
|   3 - Alterar tamanho da   |
|   lista(reseta os dados)   |
|          0 - Sair          |
==============================");
                string funçaoNum = Console.ReadLine();
                string proximoProduto = "n";

                switch (funçaoNum)
                {
                    case "1":
                        do
                        {
                            if (c + 1 <= tamanhoLista)
                            {
                                Console.Clear();
                                Console.WriteLine("\nBem vindo ao gerenciador de produtos! Sua lista possui um tamanho de " + tamanhoLista + " produtos.");
                                Console.WriteLine($@"
==============================
|           Opções:          |
|   1 - Cadastrar produtos   |
|     2 - Listar produtos    |
|   3 - Aumentar tamanho da  |
|  lista(em desenvolvimento) |
|          0 - Sair          |
==============================");

                                Console.Write("\nNome do produto: ");
                                nomesProdutos[c] = Console.ReadLine();

                                Console.Write("Preço:           ");
                                preçoProdutos[c] = float.Parse(Console.ReadLine());

                                Console.Write("Desconto(s/n):   ");
                                string InterpretadorAutomático13 = Console.ReadLine().ToLower().Substring(0, 1);

                                switch (InterpretadorAutomático13)
                                {
                                    case "s":
                                        promoProdutos[c] = "SIM";
                                        break;

                                    case "n":
                                        promoProdutos[c] = "NÃO";
                                        break;

                                    default:
                                        promoProdutos[c] = "???";
                                        break;
                                }


                                Console.Write("\nDeseja cadastrar outro produto? (s/n) --> ");
                                proximoProduto = Console.ReadLine().ToLower().Substring(0, 1);
                                c++;

                                Console.Clear();
                            }
                            else
                            {
                                proximoProduto = "n";

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("A capacida máxima da lista foi atingida.");
                                Console.ResetColor();

                            }
                        } while (proximoProduto == "s");

                        break;

                    case "2":
                        if (string.IsNullOrEmpty(nomesProdutos[0]))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nAinda não existem produtos cadastrados na lista.");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (var i = 0; i < c; i++)
                            {
                                Console.WriteLine($@"
Nome do produto: {nomesProdutos[i]}
Preço:           R$ {preçoProdutos[i]}
Desconto:        {promoProdutos[i]}
");
                            }
                            Console.Write("Pressione ENTER para sair.");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    case "3":
                        string[] nomesProdutos2 = new string[tamanhoLista];
                        float[] preçoProdutos2 = new float[tamanhoLista];
                        string[] promoProdutos2 = new string[tamanhoLista];

                        Console.Write("Qual o novo tamanho da lista? ");
                        tamanhoLista = int.Parse(Console.ReadLine());
                        Console.Clear();                        

                        for (var i = 0; i < c; i++)
                        {
                            nomesProdutos2[i] = nomesProdutos[i];
                            preçoProdutos2[i] = preçoProdutos[i];
                            promoProdutos2[i] = promoProdutos[i];                            
                        }
                        
                        nomesProdutos = new string[tamanhoLista];
                        preçoProdutos = new float[tamanhoLista];
                        promoProdutos = new string[tamanhoLista];

                        for (var i = 0; i < c; i++)
                        {
                            nomesProdutos[i] = nomesProdutos2[i];
                            preçoProdutos[i] = preçoProdutos2[i];
                            promoProdutos[i] = promoProdutos2[i];                            
                        }

                        break;

                    case "0":
                        exit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("* Valor inválido *");
                        Console.ResetColor();

                        break;
                }


            } while (exit == false);

        }
    }
}
