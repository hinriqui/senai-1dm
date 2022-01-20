using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_09.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }

        Post p = new Post();
        Usuario u = new Usuario();


        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");
            ViewBag.Stories = Sortear();
            ViewBag.Post = p.LerTodos();

            if (ViewBag.User != null)
            {
                return View();
            }

            return LocalRedirect("~/Home");
        }


        [Route("Postar")]
        public IActionResult Postar(IFormCollection form)
        {
            Usuario userAtual = new Usuario();
            Post novoPost = new Post();

            novoPost.Descricao = form["Descricao"];
            userAtual = u.UsuarioSessao(HttpContext.Session.GetString("UserName"));

            novoPost.Nome = userAtual.Nome;
            novoPost.Username = userAtual.Username;
            novoPost.Foto = userAtual.Foto;
            novoPost.Email = userAtual.Email;


            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoPost.Imagem = file.FileName;

                p.Postar(novoPost);
                return LocalRedirect("~/Feed/Listar");
            }

            Mensagem = "O campo de imagem é obrigatório";
            return LocalRedirect("~/Feed/Listar");
        }

        public List<Usuario> Sortear()
        {
            List<Usuario> sistema = u.LerTodos();
            List<Usuario> lista = new List<Usuario>();

            Random r = new Random();

            for (var i = 0; i < 7; i++)
            {
                int k = sistema.Count();
                int p = r.Next(k);


                lista.Add(sistema[p]);
                sistema.Remove(sistema[p]);
            }

            return lista;
        }
    }
}