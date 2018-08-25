using _06.Fiap.Web.MVC.Models;
using _06.Fiap.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06.Fiap.Web.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();
        // GET: Animal
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal); //adiciona no "Banco"
            _context.SaveChanges();
            TempData["msg"] = "Animal cadastrado!"; //mensagem enviada para a tela
            //faz redirect para não cadastrar vários no mesmo formulário após o F5
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Envia a lista de médicos para a tela
            _context.Animais.ToList();
            return View();
        }
    }
}