using System;

namespace DescobrirIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int anoNasc = int.Parse(Console.ReadLine());
            int anoAtual = System.DateTime.Now.Year;
            
            int idade = anoAtual - anoNasc;
            int semanas = idade * 52;
            Console.WriteLine("Certo. Então você tem " + idade + " anos. Se preferir " + semanas + " semanas.");
        }
    }
}
