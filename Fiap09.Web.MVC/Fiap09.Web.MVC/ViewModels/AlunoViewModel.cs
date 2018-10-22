using Fiap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap09.Web.MVC.ViewModels
{
    public class AlunoViewModel
    {
        public string Aluno { get; set; }

        public IList<Aluno> Alunos { get; set; }
    }
}