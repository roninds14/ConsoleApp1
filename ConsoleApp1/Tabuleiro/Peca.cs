using Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            tab = tabuleiro;
            this.qtdMovimentos = 0;
        }

        public override string ToString()
        {
            return "P ";
        }

        public void incrementarQtdDeMovimentos() {
            this.qtdMovimentos++;
        }

        public void decrementarQtdDeMovimentos()
        {
            this.qtdMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPosiveis();

            for (int i = 0; i < tab.linhas; i++)
                for (int j = 0; j < tab.colunas; j++)
                    if (mat[i, j]) return true;

            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPosiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPosiveis();
    }
}
