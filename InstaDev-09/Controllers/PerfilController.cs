using System.Collections.Generic;
using InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDev_09.Controllers
{
    public class PerfilController : Controller
    {
        Post p = new Post();

        public IActionResult Index()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");
            ViewBag.PostPerfil = p.PostPerfil(HttpContext.Session.GetString("UserName"));

            if (ViewBag.User != null)
            {
                return View();
            }

            return LocalRedirect("~/Home");
        }
    }
}