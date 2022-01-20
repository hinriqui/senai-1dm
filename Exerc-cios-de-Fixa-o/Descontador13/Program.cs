using System;

namespace Descontador13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a descrição do produto? ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Qual a quantidade de " + nomeProduto + "? ");
            int qntdProduto = int.Parse(Console.ReadLine());

            Console.Write("Qual o preço da unidade de " + nomeProduto + "? ");
            float preçoProduto = float.Parse(Console.ReadLine());

            Console.WriteLine("Há em estoque um total de R$ " + (preçoProduto * qntdProduto) + " em " + nomeProduto);

            if (qntdProduto > 10)
            {
                Console.WriteLine("De acordo com a quantidade em estoque, haverá um desconto de R$ " + (preçoProduto * 0.05) + " em cada unidade. Ou seja, o produto será vendido por R$ " + (preçoProduto * 0.95));
            }
            else if (qntdProduto > 5)
            {
                Console.WriteLine("De acordo com a quantidade em estoque, haverá um desconto de R$ " + (preçoProduto * 0.03) + " em cada unidade. Ou seja, o produto será vendido por R$ " + (preçoProduto * 0.97));
            }
            else
            {
                Console.WriteLine("De acordo com a quantidade em estoque, haverá um desconto de R$ " + (preçoProduto * 0.02) + " em cada unidade. Ou seja, o produto será vendido por R$ " + (preçoProduto * 0.98));
            }
        }
    }
}
