using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;

namespace InstaDev.Controllers
{
    public class HomeController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }

        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> csv = usuarioModel.LerTodasAsLinhasCSV("Database/Usuario.csv");

            var logado = csv.Find(
                x =>
                x.Split(";")[0] == form["Email"] &&
                x.Split(";")[3] == form["Senha"]
            );

            if (logado != null)
            {
                HttpContext.Session.SetString("UserName", logado.Split(";")[2]);
                return LocalRedirect("~/Feed/Listar");
            }

            Mensagem = "Dados incorretos, verifique suas informações e tente novamente.";
            return LocalRedirect("~/");
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

