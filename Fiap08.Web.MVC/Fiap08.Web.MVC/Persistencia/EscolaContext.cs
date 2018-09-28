using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Persistencia
{
    public class EscolaContext : DbContext
    {
        public DbSet<Responsavel>  Responsaveis { get; set; }

        public DbSet<Dependente> Dependentes { get; set; }

    }
}