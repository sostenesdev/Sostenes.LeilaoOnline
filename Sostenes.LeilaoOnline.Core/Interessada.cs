﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sostenes.LeilaoOnline.Core
{
    public class Interessada
    {
        public string Nome { get; }
        public Leilao Leilao { get; }

        public Interessada(string nome, Leilao leilao)
        {
            Nome = nome;
            Leilao = leilao;
        }
    }
}
