﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel2.Models
{
   public class Quarto
    {
        public required string Descricao { get; set; }

        public double ValorDiariaAdulto { get; set; }

        public double ValorDiariaCriancas { get; set; }
    }
}
