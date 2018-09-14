﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Display(Name = "Nome do Jogador")]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public Time Time { get; set; }

        public int TimeId { get; set; }
    }
}