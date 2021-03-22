using tabuleiro;
using Enums;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R ";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPosiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //acima
            pos.definirValores(pos.Linha - 1, pos.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //ne
            pos.definirValores(pos.Linha - 1, pos.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //direita
            pos.definirValores(pos.Linha, pos.Coluna+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //se
            pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //baixo
            pos.definirValores(pos.Linha + 1, pos.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //so
            pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //esquerda
            pos.definirValores(pos.Linha, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            //no
            pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }
    }
}
