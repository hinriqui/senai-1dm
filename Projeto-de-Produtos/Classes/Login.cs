using System;
using System.Collections.Generic;

namespace ProdutoMilGrau.Classes
{
    public class Login
    {
        Produto P = new Produto();
        private bool logado;
        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }
        public List<Usuario> ListaUsuarios = new List<Usuario>();
        public Login() { }
        public string Logar()
        {
            Console.WriteLine("E-mail: ");
            string EmailLogin = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string SenhaLogin = Console.ReadLine();

            bool EmailValidade = false;
            bool SenhaValidade = false;

            foreach (Usuario item in ListaUsuarios)
            {
                if (item.Email == EmailLogin)
                {
                    EmailValidade = true;
                }
                if (item.Senha == SenhaLogin)
                {
                    SenhaValidade = true;
                }
                if (SenhaValidade == true && EmailValidade == true)
                {
                    Logado = true;
                }
            }
            return "...";
        }
        public string Deslogar()
        {
            Logado = false;
            return "...";
        }
    }
}