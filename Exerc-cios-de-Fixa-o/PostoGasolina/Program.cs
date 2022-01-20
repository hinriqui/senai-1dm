using System;

namespace PostoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O posto de gasolina do Seu Bira te deseja 'boa tarde'! Quantos litros? ");
            double qntdLitros = float.Parse(Console.ReadLine());
            
            bool validade = false;
            string tipoGasosa;

            do
            {
            Console.Write("Gasolina ou álcool? ");
            tipoGasosa = Console.ReadLine().ToLower().Substring(0,1);
            if (tipoGasosa == "g" || tipoGasosa == "a")
            {
                validade = true;
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
            }
            } while (validade == false);
            
            Console.WriteLine("Processo concluído, o preço a ser pago é de: R$ " + Math.Round(preçoGasosa(tipoGasosa, qntdLitros)));

        }

        static double preçoGasosa(string tipoGasosa, double qntdLitros)
        {
            switch (tipoGasosa)
            {
                case "g":
                    if (qntdLitros <= 20)
                    {
                        return qntdLitros * 5.3 * 0.96;
                    } 
                    else 
                    {
                        return qntdLitros * 5.3 * 0.94;
                    }

                case "a":
                    if (qntdLitros <= 20)
                    {
                        return qntdLitros * 5.3 * 0.97;
                    }
                    else
                    {
                        return qntdLitros * 5.3 * 0.95; 
                    }

                default:
                    return 0;
                    
            }
            
        }
    }
}
