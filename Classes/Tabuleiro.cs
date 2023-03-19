using System;
using System.Collections.Generic;
using System.Drawing;
using XadrezWpf.Classes.Enumerators;

namespace XadrezWpf.Classes
{
    public class Tabuleiro
    {
        public Ordenacao Ordenacao { get; set; }
        public Posicao[,]? Mapeamento { get; set; }
        public List<String> PossibilidadesDeJogadas { get; set; }
        public ListaDePecas ListaDePecas { get; set; }

        public Tabuleiro()
        {
            Ordenacao = new Ordenacao();
            ListaDePecas= new ListaDePecas();
        }

        #region Posicionamento
        public void InicializarPosicoes()
        {
            MapearPosicoes();
            PosicionarPecas();
        }
        public void MapearPosicoes()
        {
            Mapeamento = new Posicao[8, 8]
            {
                { new Posicao("a8",CorDaCasa.White), new Posicao("b8",CorDaCasa.DimGray),new Posicao("c8",CorDaCasa.White),new Posicao("d8",CorDaCasa.DimGray),new Posicao("e8",CorDaCasa.White),new Posicao("f8",CorDaCasa.DimGray),new Posicao("g8",CorDaCasa.White),new Posicao("h8",CorDaCasa.DimGray) },
                { new Posicao("a7",CorDaCasa.DimGray), new Posicao("b7",CorDaCasa.White),new Posicao("c7",CorDaCasa.DimGray),new Posicao("d7",CorDaCasa.White),new Posicao("e7",CorDaCasa.DimGray),new Posicao("f7",CorDaCasa.White),new Posicao("g7",CorDaCasa.DimGray),new Posicao("h7",CorDaCasa.White) },
                { new Posicao("a6",CorDaCasa.White), new Posicao("b6",CorDaCasa.DimGray),new Posicao("c6",CorDaCasa.White),new Posicao("d6",CorDaCasa.DimGray),new Posicao("e6",CorDaCasa.White),new Posicao("f6",CorDaCasa.DimGray),new Posicao("g6",CorDaCasa.White),new Posicao("h6",CorDaCasa.DimGray) },
                { new Posicao("a5",CorDaCasa.DimGray), new Posicao("b5",CorDaCasa.White),new Posicao("c5",CorDaCasa.DimGray),new Posicao("d5",CorDaCasa.White),new Posicao("e5",CorDaCasa.DimGray),new Posicao("f5",CorDaCasa.White),new Posicao("g5",CorDaCasa.DimGray),new Posicao("h5",CorDaCasa.White) },
                { new Posicao("a4",CorDaCasa.White), new Posicao("b4",CorDaCasa.DimGray),new Posicao("c4",CorDaCasa.White),new Posicao("d4",CorDaCasa.DimGray),new Posicao("e4",CorDaCasa.White),new Posicao("f4",CorDaCasa.DimGray),new Posicao("g4",CorDaCasa.White),new Posicao("h4",CorDaCasa.DimGray) },
                { new Posicao("a3",CorDaCasa.DimGray), new Posicao("b3",CorDaCasa.White),new Posicao("c3",CorDaCasa.DimGray),new Posicao("d3",CorDaCasa.White),new Posicao("e3",CorDaCasa.DimGray),new Posicao("f3",CorDaCasa.White),new Posicao("g3",CorDaCasa.DimGray),new Posicao("h3",CorDaCasa.White) },
                { new Posicao("a2",CorDaCasa.White), new Posicao("b2",CorDaCasa.DimGray),new Posicao("c2",CorDaCasa.White),new Posicao("d2",CorDaCasa.DimGray),new Posicao("e2",CorDaCasa.White),new Posicao("f2",CorDaCasa.DimGray),new Posicao("g2",CorDaCasa.White),new Posicao("h2",CorDaCasa.DimGray) },
                { new Posicao("a1",CorDaCasa.DimGray), new Posicao("b1",CorDaCasa.White),new Posicao("c1",CorDaCasa.DimGray),new Posicao("d1",CorDaCasa.White),new Posicao("e1",CorDaCasa.DimGray),new Posicao("f1",CorDaCasa.White),new Posicao("g1",CorDaCasa.DimGray),new Posicao("h1",CorDaCasa.White) }
            };
        }

        public void PosicionarPecas()
        {
            PosicionarPeoesBrancos();
            PosicionarPecasEspeciaisBrancas();
            PosicionarPeoesPretos();
            PosicionarPecasEspeciaisPretas();
        }

        public void PosicionarPeoesBrancos()
        {
            int Linha = 6;
            
            for(int Coluna = 0; Coluna < 8; Coluna++)
            {
                Mapeamento[Linha, Coluna].Peca = ListaDePecas.PeoesBrancos[Coluna];
                Mapeamento[Linha, Coluna].Peca.Coordenada = new Coordenada(Linha, Coluna);
            }
        }

        public void PosicionarPecasEspeciaisBrancas()
        {
            int Linha = 7;

            for (int Coluna = 0; Coluna < 8; Coluna++)
            {
                Mapeamento[Linha, Coluna].Peca = ListaDePecas.PecasEspeciaisBrancas[Coluna];
                Mapeamento[Linha, Coluna].Peca.Coordenada = new Coordenada(Linha, Coluna);
            }
        }

        public void PosicionarPeoesPretos()
        {
            int Linha = 1;

            for (int Coluna = 0; Coluna < 8; Coluna++)
            {
                Mapeamento[Linha, Coluna].Peca = ListaDePecas.PeoesPretos[Coluna];
                Mapeamento[Linha, Coluna].Peca.Coordenada = new Coordenada(Linha, Coluna);
            }
        }

        public void PosicionarPecasEspeciaisPretas()
        {
            int Linha = 0;

            for (int Coluna = 0; Coluna < 8; Coluna++)
            {
                Mapeamento[Linha, Coluna].Peca = ListaDePecas.PecasEspeciaisPretas[Coluna];
                Mapeamento[Linha, Coluna].Peca.Coordenada = new Coordenada(Linha, Coluna);
            }
        }
        #endregion

        #region Utilitários
        public System.Windows.Media.SolidColorBrush RetornarCorDaCasaPorIndice(string casa)
        {
            var CorDaCasa = System.Windows.Media.Brushes.Red;

            for(int Linha = 0; Linha < 8; Linha++)
            {
                for (int Coluna = 0; Coluna < 8; Coluna++)
                {
                    if (Mapeamento[Linha, Coluna].Indice == casa)
                         CorDaCasa = (Mapeamento[Linha, Coluna].Cor == Enumerators.CorDaCasa.White) ? System.Windows.Media.Brushes.White : System.Windows.Media.Brushes.DimGray;
                }
            }

            return CorDaCasa;
        }
        public bool VerificarPecaPosicionadaPorIndice(string indice)
        {
            bool PecaPosicionada = false;

            for (int Linha = 0; Linha < 8; Linha++)
            {
                for (int Coluna = 0; Coluna < 8; Coluna++)
                {
                    if (Mapeamento[Linha, Coluna].Indice == indice && Mapeamento[Linha,Coluna].Peca != null)
                        PecaPosicionada = true;
                }
            }

            return PecaPosicionada;
        }
        #endregion

        #region PossibilidadeJogadas

        #endregion
    }
}
