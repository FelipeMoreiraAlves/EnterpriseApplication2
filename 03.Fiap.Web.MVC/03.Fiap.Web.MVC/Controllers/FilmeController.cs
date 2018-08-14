using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        // GET: Filme
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            //Passar valores para a view (pagina html)
            ViewBag.titulo = filme.Nome;
            TempData["msg"] = "Filme cadastrado!!";
            return View(filme); //envia o filme para a tela
            //retorna um texto para o browser
            //return Content(filme.Genero);
        }
    }
}