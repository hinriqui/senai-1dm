using System;
namespace Super_Cafeteira_Tabajaras_Plus
{
    public class MaquinaCafe
    {
        public float acucarDisponivel = 100;
        public bool cafeFeito = false;
        public float ultimoPedido;
        public void fazerCafe(float acucarQntdade)
        {
            ultimoPedido = acucarQntdade;
            if (acucarDisponivel < acucarQntdade)
            {
                Console.Write("Infelizmente não temos essa quantidade de açucar no sistema. Pedimos que faça um novo pedido ou contate algum dos nossos funcionários.\nPressione ENTER para finalizar o pedido");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                acucarDisponivel = acucarDisponivel - acucarQntdade;
                cafeFeito = true;
            }

        }
        public void fazerCafe()
        {
            ultimoPedido = 10;
            if (acucarDisponivel < 10)
            {
                Console.Write("Infelizmente não temos essa quantidade de açucar no sistema. Pedimos que faça um novo pedido ou contate algum dos nossos funcionários.\nPressione ENTER para finalizar o pedido");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                acucarDisponivel = acucarDisponivel - 10;
                cafeFeito = true;
            }
        }
    }
}