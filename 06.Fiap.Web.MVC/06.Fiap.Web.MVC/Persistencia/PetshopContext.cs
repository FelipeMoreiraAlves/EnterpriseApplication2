using _06.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _06.Fiap.Web.MVC.Persistencia
{
    public class PetshopContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}