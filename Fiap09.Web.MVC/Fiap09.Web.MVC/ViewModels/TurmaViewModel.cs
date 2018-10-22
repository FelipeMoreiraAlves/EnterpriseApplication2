using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap09.Web.MVC.Models
{
    public class TurmaViewModel
    {
        public string Turma { get; set; }

        public IList<Turma> Turmas { get; set; }

    }
}