using System;
using System.Collections.Generic;

namespace ProdutoMilGrau.Classes
{
    public class Marca
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nomeMarca;
        public string NomeMarca
        {
            get { return nomeMarca; }
            set { nomeMarca = value; }
        }
        private DateTime dataCadastro;
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public string Cadastrar()
        {
            return "Cadastro concluído!";
        }
        public string Listar() {
            return "Marcas listadas!";
        }
        public string Deletar() {
            return "Marca deletada!";
        }

        public List<Marca> Marcas = new List<Marca>();
        public Marca() { }
        public Marca(string _NomeMarca)
        {
            Random r = new Random();
            Codigo = r.Next(3000000);
            NomeMarca = _NomeMarca;
            DataCadastro = DateTime.Now;
        }
    }
}