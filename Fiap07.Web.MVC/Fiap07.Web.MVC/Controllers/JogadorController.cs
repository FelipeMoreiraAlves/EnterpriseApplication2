using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();
        // GET: Jogador
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.Times.ToList();

            ViewBag.times = new SelectList(lista, "TimeId", "Nome");

            return View();
        }
        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Jogadores.Include("Time").ToList();
            return View(lista);
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();

            TempData["msg"] = "Jogador cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }
    }
}