using _04.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Fiap.Web.MVC.Controllers
{
    public class MedicoController : Controller
    {
        //Simular um banco de dados
        private static List<Medico> _banco = new List<Medico>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Medico medico)
        {
            _banco.Add(medico); //adiciona no "Banco"
            TempData["msg"] = "Médico cadastrado!"; //mensagem enviada para a tela
            //faz redirect para não cadastrar vários no mesmo formulário após o F5
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Envia a lista de médicos para a tela
            return View(_banco);
        }
    }
}