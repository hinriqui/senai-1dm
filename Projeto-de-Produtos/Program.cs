using System;
using System.Collections.Generic;
using ProdutoMilGrau.Classes;

namespace ProdutoMilGrau
{
    class Program
    {
        static void Main(string[] args)
        {
            Marca M = new Marca();
            Produto P = new Produto();
            Usuario U = new Usuario();
            Login L = new Login();

            bool fim = false;
            bool Sair = false;
            do
            {
                do
                {
                    Console.WriteLine($@"
1. Cadastrar usuário
2. Listar usuários
3. Excluir usuário
4. Logar
0. Sair");

                    switch (Console.ReadLine())
                    {
                        case "0":
                            Sair = true;
                            L.Logado = true;
                            fim = true;
                            break;
                        case "1":
                            Console.Write("Nome de usuário: ");
                            string NomeUsuario = Console.ReadLine();

                            Console.Write("E-mail: ");
                            string EmailUsuario = Console.ReadLine();

                            Console.Write("Senha: ");
                            string SenhaUsuario = Console.ReadLine();

                            L.ListaUsuarios.Add(new Usuario(NomeUsuario, EmailUsuario, SenhaUsuario));
                            break;

                        case "2":
                            foreach (Usuario item in L.ListaUsuarios)
                            {
                                Console.WriteLine($@"{item.Codigo} | {item.Nome} | {item.Email} | {item.DataCadastro}");
                            }

                            Console.WriteLine("Usuários listados!");
                            Console.Write("Pressione ENTER para voltar.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Write("Qual o código do usuário que você quer remover? ");
                            L.ListaUsuarios.RemoveAll(x => x.Codigo == int.Parse(Console.ReadLine()));
                            break;
                        case "4":
                            L.Logar();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                } while (L.Logado == false);

                if (Sair == false)
                {
                    do
                    {
                        Console.Write($@"
1. Cadastrar produto
2. Listar produtos
3. Excluir produto
4. Gerenciar marcas
5. Deslogar
");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Qual o nome do produto cadastrado? ");
                                string NomeProduto = Console.ReadLine();

                                Console.Write("Qual a marca do produto? ");
                                string NomeMarcaProduto = Console.ReadLine();

                                Console.Write("Qual o preço do produto? ");
                                float PrecoProduto = float.Parse(Console.ReadLine());

                                Marca MarcaProduto = null;
                                MarcaProduto = M.Marcas.Find(item => item.NomeMarca == NomeMarcaProduto);

                                P.Carrinho.Add(new Produto(NomeProduto, PrecoProduto, MarcaProduto, NomeMarcaProduto));
                                break;

                            case "2":
                                foreach (Produto item in P.Carrinho)
                                {
                                    Console.WriteLine($@"{item.Codigo} | {item.NomeProduto} {item.NomeMarcaProduto} | {item.Preco:c2} | {item.DataCadastro}");
                                }

                                Console.WriteLine("Produtos listados!");
                                Console.Write("Pressione ENTER para voltar.");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":
                                Console.Write("Qual o código do produto que você quer remover? ");
                                P.Carrinho.RemoveAll(x => x.Codigo == int.Parse(Console.ReadLine()));
                                break;

                            case "4":
                                Console.Clear();
                                do
                                {
                                    Console.Write($@"
1. Cadastrar marca
2. Listar marcas
3. Excluir marca
4. Sair
");

                                    switch (Console.ReadLine())
                                    {
                                        case "0":
                                            Sair = true;
                                            break;
                                        case "1":
                                            Console.Write("Qual o nome da nova marca? ");
                                            string NomeMarca = Console.ReadLine();

                                            M.Marcas.Add(new Marca(NomeMarca));
                                            Console.WriteLine(M.Cadastrar());
                                            break;

                                        case "2":
                                            foreach (Marca item in M.Marcas)
                                            {
                                                Console.WriteLine($@" {item.Codigo} | {item.NomeMarca} | {item.DataCadastro}");
                                            }
                                            Console.WriteLine(M.Listar());
                                            Console.Write("Pressione ENTER para voltar.");
                                            Console.ReadLine();
                                            break;

                                        case "3":
                                            Console.Write("Qual o código da marca que você quer remover? ");
                                            M.Marcas.RemoveAll(x => x.Codigo == int.Parse(Console.ReadLine()));
                                            break;
                                        case "4":
                                            Sair = true;
                                            break;
                                        default:
                                            Console.WriteLine("Valor inválido.");
                                            break;
                                    }
                                    Console.Clear();
                                } while (Sair == false);
                                Sair = false;
                                break;

                            case "5":
                                Sair = true;
                                L.Deslogar();

                                break;

                            default:
                                break;
                        }
                        Console.Clear();
                    } while (Sair == false);
                    Sair = false;
                }
            } while (fim == false);
        }
    }
}