using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.Entities.TabuleiroRegras
{
    internal class Posicao
    {
        public int Linha { get; set; }

        public int Coluna { get; set; }

        public Posicao() { }

        public Posicao(int linhas, int coluna)
        {
            Linha = linhas;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
