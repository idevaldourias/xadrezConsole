using XadrezConsole.Entities.TabuleiroRegras;
using XadrezConsole.Entities.Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 6));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}