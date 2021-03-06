using tabuleiro;
using Enums;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T ";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPosiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0,0);

            pos.Linha = posicao.Linha;
            pos.Coluna = posicao.Coluna;

            //acima
            pos.definirValores(pos.Linha - 1, pos.Coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) break;

                pos.Linha = pos.Linha - 1;
            }

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //abaixo
            pos.definirValores(pos.Linha + 1, pos.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) break;

                pos.Linha = pos.Linha + 1;
            }

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //direita
            pos.definirValores(pos.Linha, pos.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) break;

                pos.Coluna = pos.Coluna + 1;
            }

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //esquerda
            pos.definirValores(pos.Linha, pos.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) break;

                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }
    }
}
