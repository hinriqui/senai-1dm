using System.Collections.Generic;
using System.IO;
using InstaDev_09.Interface;
using InstaDev_09.Models;

namespace InstaDev.Models
{
    public class Post : InstadevBase, IPost
    {
        public string Descricao;
        public string Imagem;
        // public Usuario User;
        public string Username;
        public string Nome;
        public string Foto;
        public string Email;

        private const string CAMINHO = "Database/Post.csv";
        public Post()
        {
            CriarPastaEArquivo(CAMINHO);
        }
        private string PrepararLinha(Post p)
        {
            return $"{p.Descricao};{p.Imagem};{p.Nome};{p.Username};{p.Foto};{p.Email}";
        }

        public void Postar(Post p)
        {
            string[] Linha = { PrepararLinha(p) };
            File.AppendAllLines(CAMINHO, Linha);
        }

        public List<Post> LerTodos()
        {
            List<Post> posts = new List<Post>();
            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Post post = new Post();
                post.Descricao = linha[0];
                post.Imagem = linha[1];
                post.Nome = linha[2];
                post.Username = linha[3];
                post.Foto = linha[4];
                post.Email = linha[5];

                posts.Add(post);
            }
            return posts;
        }

         public List<Post> PostPerfil(string username){

            List<Post> Todos_Posts = LerTodos();

            List<Post> Usuario_Posts = new List<Post>();

            foreach (var item in Todos_Posts)
            {
                if (item.Username == username)
                {
                    Usuario_Posts.Add(item);
                }
            }
        
          return Usuario_Posts;
        }

        public void MudarIdentidade(Usuario _IdentidadeSuja, Usuario _IdentidadeNova)
        {
            List<Post> _Sistema = LerTodos();
            foreach (var Post in _Sistema)
            {
                if (Post.Username == _IdentidadeSuja.Username) //if (algum vestígio for encontrado)
                {
                    Post.Nome = _IdentidadeNova.Nome;
                    Post.Username = _IdentidadeNova.Username;
                    Post.Foto = _IdentidadeNova.Foto;
                    Post.Email = _IdentidadeNova.Email;
                }
            }

            File.Delete(CAMINHO);

            foreach (var Post in _Sistema)
            {
                Postar(Post);
            }            
        }
    }
}