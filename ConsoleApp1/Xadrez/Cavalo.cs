using tabuleiro;
using Enums;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "C ";
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

            //Acima
            pos.definirValores(pos.Linha + 2, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;
            
            pos.definirValores(pos.Linha + 2, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //Direita
            pos.definirValores(pos.Linha + 1, pos.Coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            pos.definirValores(pos.Linha - 1, pos.Coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //Abaixo
            pos.definirValores(pos.Linha - 2, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            pos.definirValores(pos.Linha -  2, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //Esquerda
            pos.definirValores(pos.Linha + 1, pos.Coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            pos.definirValores(pos.Linha - 1, pos.Coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }
    }
}
