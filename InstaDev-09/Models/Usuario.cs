using System.Collections.Generic;
using System.IO;
using InstaDev_09.Interfaces;
using InstaDev_09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev.Models
{
    public class Usuario : InstadevBase , IUsuario
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Foto = "padrao.png";
        
        private const string CAMINHO = "Database/Usuario.csv";

         public Usuario()
        {
            CriarPastaEArquivo(CAMINHO);
        }

        private string Preparar(Usuario u)
        {
            return $"{u.Email};{u.Nome};{u.Username};{u.Senha};{u.Foto}";
        }

        public void Cadastrar(Usuario u)
        {
            string[] linha = {Preparar(u)};
            File.AppendAllLines (CAMINHO, linha);
        }

        public List<Usuario> LerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(CAMINHO); 

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario novoUsuario = new Usuario();
                novoUsuario.Email = linha[0];
                novoUsuario.Nome = linha[1];
                novoUsuario.Username = linha[2];
                novoUsuario.Senha = linha[3];
                novoUsuario.Foto = linha[4];

                usuarios.Add(novoUsuario);
            }

            return usuarios; 
        }

        public void Excluir(Usuario user)
        {
          List<string> linhas = LerTodasAsLinhasCSV(CAMINHO);
          linhas.RemoveAll(x => x.Split(";")[2] == user.Username);
          ReescreverCSV(CAMINHO, linhas);
        }

        public Usuario UsuarioSessao(string _username)
        {
            List<Usuario> Sistema = LerTodos();
            Usuario _user = new Usuario();
            
            foreach (Usuario usuario in Sistema)
            {
                if (usuario.Username == _username)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}