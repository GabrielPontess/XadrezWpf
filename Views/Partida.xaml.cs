using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using XadrezWpf.Classes;
using XadrezWpf.Classes.Enumerators;
using XadrezWpf.Pieces;

namespace XadrezWpf.Views
{
    public partial class Partida : Window
    {
        #region Props

        private Tabuleiro TabuleiroDaPartida { get; set; }
        private StackPanel CasaSelecionada { get; set; }
        private StackPanel UltimaCasaSelecionada { get; set; }
        private bool JogadaEmAndamento { get; set; } = false;

        #endregion


        public Partida()
        {
            InitializeComponent();
            InicializarPartida();
        }

        #region Inicializações

        public void InicializarPartida()
        {
            InicializarTabuleiro();
            InicializarPeoesBrancos();
            InicializarPecasEspeciaisBrancas();
            InicializarPeoesPretos();
            InicializarPecasEspeciaisPretas();
            TabuleiroDaPartida.InicializarPosicoes();
            PosicionarPecasTabuleiroInterface();
        }

        public void InicializarTabuleiro()
        {
            TabuleiroDaPartida = new Tabuleiro();
        }

        public void PosicionarPecasTabuleiroInterface()
        {
            #region Peças Brancas
            a2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[0]);
            b2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[1]);
            c2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[2]);
            e2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[3]);
            f2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[4]);
            g2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[5]);
            h2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[6]);
            d2.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesBrancos[7]);
            a1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[0]);
            b1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[1]);
            c1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[2]);
            d1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[3]);
            e1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[4]);
            f1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[5]);
            g1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[6]);
            h1.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas[7]);

            #endregion

            #region Peças Pretas
            a7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[0]);
            b7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[1]);
            c7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[2]);
            e7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[3]);
            f7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[4]);
            g7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[5]);
            h7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[6]);
            d7.Children.Add(TabuleiroDaPartida.ListaDePecas.PeoesPretos[7]);
            a8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[0]);
            b8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[1]);
            c8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[2]);
            d8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[3]);
            e8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[4]);
            f8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[5]);
            g8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[6]);
            h8.Children.Add(TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas[7]);
            #endregion

        }

        public void InicializarPeoesBrancos()
        {
            int IndicePosicao = 2;
            TabuleiroDaPartida.ListaDePecas.PeoesBrancos = new List<Peca>();

            for (int i = 0; i < 8; i++)
            {
                string Posicao = TabuleiroDaPartida.Ordenacao.OrdemLetrasTabuleiro[i] + IndicePosicao;
                Peca peao = new Peca(i + 1, Classes.Enumerators.TipoPeca.Peao, Posicao, CorDaPeca.Branca);
                TabuleiroDaPartida.ListaDePecas.PeoesBrancos.Add(peao);
            }
        }

        public void InicializarPecasEspeciaisBrancas()
        {
            int IndicePosicao = 1;
            TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas = new List<Peca>();

            for (int i = 0; i < 8; i++)
            {
                string Posicao = TabuleiroDaPartida.Ordenacao.OrdemLetrasTabuleiro[i] + IndicePosicao;
                Peca PecaEspecial = new Peca(i + 1, TabuleiroDaPartida.Ordenacao.OrdemPecasEspeciais[i], Posicao, CorDaPeca.Branca);
                TabuleiroDaPartida.ListaDePecas.PecasEspeciaisBrancas.Add(PecaEspecial);
            }
        }

        public void InicializarPeoesPretos()
        {
            int IndicePosicao = 7;
            TabuleiroDaPartida.ListaDePecas.PeoesPretos = new List<Peca>();

            for (int i = 0; i < 8; i++)
            {
                string Posicao = TabuleiroDaPartida.Ordenacao.OrdemLetrasTabuleiro[i] + IndicePosicao;
                Peca peao = new Peca(i + 1, Classes.Enumerators.TipoPeca.Peao, Posicao, CorDaPeca.Preta);
                TabuleiroDaPartida.ListaDePecas.PeoesPretos.Add(peao);
            }
        }

        public void InicializarPecasEspeciaisPretas()
        {
            int IndicePosicao = 1;
            TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas = new List<Peca>();

            for (int i = 0; i < 8; i++)
            {
                string Posicao = TabuleiroDaPartida.Ordenacao.OrdemLetrasTabuleiro[i] + IndicePosicao;
                Peca PecaEspecial = new Peca(i + 1, TabuleiroDaPartida.Ordenacao.OrdemPecasEspeciais[i], Posicao, CorDaPeca.Preta);
                TabuleiroDaPartida.ListaDePecas.PecasEspeciaisPretas.Add(PecaEspecial);
            }
        }

        #endregion

        private void SelecionarCasa(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UltimaCasaSelecionada = CasaSelecionada;
            CasaSelecionada = sender as StackPanel;

            if (TabuleiroDaPartida.VerificarPecaPosicionadaPorIndice(CasaSelecionada.Name))
            {
                if (!CasaSelecionadaAnteriormente())
                {
                    if (UltimaCasaSelecionada == null)
                    {
                        CasaSelecionada.Background = System.Windows.Media.Brushes.Red;
                    }
                    else
                    {
                        UltimaCasaSelecionada.Background = TabuleiroDaPartida.RetornarCorDaCasaPorIndice(UltimaCasaSelecionada.Name);
                        CasaSelecionada.Background = System.Windows.Media.Brushes.Red;

                    }
                }
                else
                {
                    CasaSelecionada.Background = TabuleiroDaPartida.RetornarCorDaCasaPorIndice(CasaSelecionada.Name);

                    JogadaEmAndamento = false;
                   
                }

                JogadaEmAndamento = true;
            }
            else
            {
                if (UltimaCasaSelecionada != null)
                {
                    UltimaCasaSelecionada.Background = TabuleiroDaPartida.RetornarCorDaCasaPorIndice(UltimaCasaSelecionada.Name);
                }

                CasaSelecionada.Background = TabuleiroDaPartida.RetornarCorDaCasaPorIndice(CasaSelecionada.Name);

                JogadaEmAndamento = false;
            }
        }

        private bool CasaSelecionadaAnteriormente()
        {
            return CasaSelecionada.Background == System.Windows.Media.Brushes.Red;
        }
    }
}
