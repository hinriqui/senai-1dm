using System;
using EPlayersMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayersMVC.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador j = new Jogador();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogadores = j.LerTudo();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            j.Criar(novoJogador);
            ViewBag.Jogadores = j.LerTudo();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("{id}")]
        public IActionResult Excluir(int id){
            j.Deletar(id);
            ViewBag.Jogadores = j.LerTudo();
            return LocalRedirect("~/Jogador/Listar");
        }
    }
}