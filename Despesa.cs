﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public class Despesa : Transacao
    {
        public Despesa()
        {
            Tipo = "despesa";
        }

        public string Tipo { get; set; }
    }
}
