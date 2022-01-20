using System;
namespace JogadorVelho
{
    public class Jogador
    {
        public string Nome;
        public int AnoNasc = 20;
        public string Naçao;
        public float Altura;
        public float Peso;
        public int Idade;
        public int idade() {
           Idade = DateTime.Now.Year - (AnoNasc);
           return Idade;
        }
    }
}