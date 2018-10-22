using Fiap09.Web.MVC.Models;
using Fiap09.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap09.Web.MVC.Controllers
{
    public class AlunoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.TurmaRepository.Listar();
            ViewBag.churros = new SelectList(lista, "TurmaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Aluno aluno)
        {
            _unit.AlunoRepository.Cadastrar(aluno);
            _unit.Salvar();
            TempData["msg"] = "Aluno cadastrado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}