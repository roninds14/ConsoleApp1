using tabuleiro;
using Enums;

namespace Xadrez
{
    class Peao : Peca
    {
        public int direcao; 

        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            direcao = cor == Cor.Branca ? -1 : 1;
        }

        public override string ToString()
        {
            return "P ";
        }

        private bool existeImigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
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

            //Mover
            pos.definirValores(pos.Linha + direcao, pos.Coluna);
            if (tab.posicaoValida(pos) && livre(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            pos.definirValores(pos.Linha + (direcao * 2), pos.Coluna);
            if (tab.posicaoValida(pos) && livre(pos) && qtdMovimentos == 0 )
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            //Capturar
            pos.definirValores(pos.Linha + direcao, pos.Coluna + 1);
            if (tab.posicaoValida(pos) && existeImigo(pos))
                mat[pos.Linha, pos.Coluna] = true;

            pos.Linha = this.posicao.Linha;
            pos.Coluna = this.posicao.Coluna;

            pos.definirValores(pos.Linha + direcao, pos.Coluna - 1);
            if (tab.posicaoValida(pos) && existeImigo(pos) && qtdMovimentos == 0)
                mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }
    }
}
