using System;
using System.Collections.Generic;

namespace ProdutoMilGrau.Classes
{
    public class Produto
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nomeProduto;
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        private float preco;
        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private DateTime dataCadastro;
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        private Marca marca;
        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string nomeMarcaProduto;
        public string NomeMarcaProduto
        {
            get { return nomeMarcaProduto; }
            set { nomeMarcaProduto = value; }
        }
        private Usuario cadastradoPor;
        public Usuario CadastradoPor
        {
            get { return cadastradoPor; }
            set { cadastradoPor = value; }
        }
        public List<Produto> Carrinho = new List<Produto>();
        public string Cadastrar()
        {
            return "Cadastro concluído!";
        }
        public Produto() { }
        public Produto(string _NomeProduto, float _Preco, Marca _Marca, string _NomeMarcaProduto)
        {
            Random r = new Random();
            codigo = r.Next(3000000);
            NomeProduto = _NomeProduto;
            preco = _Preco;
            _Marca = Marca;
            nomeMarcaProduto = _NomeMarcaProduto;
            dataCadastro = DateTime.Now;
        }
    }
}