using System;
using System.Collections.Generic;
using System.IO;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_09.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }

        Usuario usuarioModel = new Usuario();

        [Route("Listar")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario usuarioModel = new Usuario();
            List<Usuario> Sistema = usuarioModel.LerTodos();
            bool erro = false;

            Usuario novoUsuario = new Usuario();
            novoUsuario.Email = form["Email"];
            novoUsuario.Nome = form["Nome"];
            novoUsuario.Username = form["Username"];
            novoUsuario.Senha = form["Senha"];

            foreach (Usuario item in Sistema)
            {
                if (novoUsuario.Email == item.Email || novoUsuario.Username == item.Username)
                {
                    erro = true;
                }
            }

            if (erro == true)
            {
                Mensagem = "Email ou nome de usuário já cadastrado";
                return LocalRedirect("~/Cadastro/Listar");
            }

            usuarioModel.Cadastrar(novoUsuario);
            return LocalRedirect("~/Home");
        }

        [Route("Excluir")]
        public IActionResult Excluir(Usuario u)
        {
            usuarioModel.Excluir(u);
            ViewBag.usuarios = usuarioModel.LerTodos();
            return LocalRedirect("~");
        }
    }
}