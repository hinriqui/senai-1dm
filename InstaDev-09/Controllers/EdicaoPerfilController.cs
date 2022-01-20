using System.Collections.Generic;
using System.IO;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_09.Controllers
{
    [Route("EdicaoPerfil")]
    public class EdicaoPerfilController : Controller
    {
        Usuario u = new Usuario();
        Post p = new Post();

        [TempData]
        public string Mensagem { get; set; }

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");

            if (ViewBag.User != null)
            {
                return View();
            }

            return LocalRedirect("~/Home");
        }

        [Route("Editar")]
        public IActionResult Edicao(IFormCollection form)
        {
            Usuario User = u.UsuarioSessao(HttpContext.Session.GetString("UserName"));
            Usuario UserVelho = u.UsuarioSessao(HttpContext.Session.GetString("UserName"));

            User.Nome = form["Nome"];
            User.Username = form["Username"];
            User.Email = form["Email"];

            u.Excluir(UserVelho);
            List<Usuario> Sistema = u.LerTodos();

            foreach (Usuario item in Sistema)
            {
                if (User.Email == item.Email || User.Username == item.Username)
                {
                    u.Cadastrar(UserVelho);
                    Mensagem = "Email ou nome de usuário já cadastrado";
                    return LocalRedirect("~/EdicaoPerfil/Listar");
                }
            }

            u.Cadastrar(User);
            p.MudarIdentidade(UserVelho, User);
            HttpContext.Session.SetString("UserName", User.Username);
            return LocalRedirect("~/Perfil");
        }

        [Route("AlterarImagem")]
        public IActionResult AlterarImagem(IFormCollection form)
        {
            if (form.Files.Count > 0)
            {
                Usuario User = u.UsuarioSessao(HttpContext.Session.GetString("UserName"));
                Usuario UserVelho = u.UsuarioSessao(HttpContext.Session.GetString("UserName"));

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/perfis");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                User.Foto = file.FileName;

                u.Excluir(u.UsuarioSessao(HttpContext.Session.GetString("UserName")));
                u.Cadastrar(User);
                p.MudarIdentidade(UserVelho, User);
                return LocalRedirect("~/Perfil");
            }
            return LocalRedirect("~/EdicaoPerfil/Listar");
        }

        public IActionResult Deletar()
        {
            u.Excluir(u.UsuarioSessao(HttpContext.Session.GetString("UserName")));
            return LocalRedirect("~/Home");
        }
    }
}