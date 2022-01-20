using System;
namespace ProdutoMilGrau.Classes
{
    public class Usuario
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private DateTime dataCadastro;
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        public string Cadastrar() {
            return "Usuário cadastrado!";
        }
        public string Deletar() {
            return "Usuário deletado!";
        }

        public Usuario() {}
        public Usuario(string _Nome, string _Email, string _Senha) {
            Random r = new Random();
            codigo = r.Next(3000000);
            nome = _Nome;
            email = _Email;
            senha = _Senha;
            dataCadastro = DateTime.Now;
        }
    }
}