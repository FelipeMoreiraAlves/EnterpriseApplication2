using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class DependenteController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();
        // GET: Dependente
        public ActionResult Cadastrar(Dependente dependente)
        {
            _unit.DependenteRepository.Cadastrar(dependente);
            _unit.Salvar();
            TempData["msg"] = "Dependente cadastrado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}