using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.Entities.Tabuleiro
{
    internal class Posicao
    {
        public int Linhas { get; set; }

        public int Coluna { get; set; }

        public Posicao() { }

        public Posicao(int linhas, int coluna)
        {
            Linhas = linhas;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linhas + ", " + Coluna;
        }
    }
}
