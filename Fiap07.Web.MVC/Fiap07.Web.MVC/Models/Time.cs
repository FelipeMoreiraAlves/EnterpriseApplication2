﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Display(Name = "Nome do Time")]
        public string  Nome { get; set; }

        public bool Mundial { get; set; }

        //Relacionamento
        public Tecnico Tecnico { get; set; }

        public int TecnicoId { get; set; }

        public virtual IList<Jogador> Jogadores  { get; set; }

        public virtual IList<Campeonato> Campeonatos { get; set; }
    }
}