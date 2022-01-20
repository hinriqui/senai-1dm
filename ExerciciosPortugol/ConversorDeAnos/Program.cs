using System;

namespace ConversorDeAnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int qntdAnos = int.Parse(Console.ReadLine());

            int qntdMeses = qntdAnos * 12;
            int qntdDias = qntdMeses * 30;
            int qntdHoras = qntdDias * 24;
            int qntdMin = qntdHoras * 60;
            int qntdSeg = qntdMin * 60;

            Console.WriteLine("Se você acha pouco pense nisso... " + qntdAnos + " anos equivalem a: ");
            Console.WriteLine(qntdMeses + " meses");
            Console.WriteLine(qntdDias + " dias");
            Console.WriteLine(qntdHoras + " horas");
            Console.WriteLine(qntdMin + " minutos");
            Console.WriteLine(qntdSeg + " segundos");
        }
    }
}
