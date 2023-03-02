﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Entities.TabuleiroRegras;

namespace XadrezConsole.Entities.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
