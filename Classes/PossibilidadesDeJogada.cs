using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using XadrezWpf.Classes.Enumerators;
using XadrezWpf.Pieces;

namespace XadrezWpf.Classes
{
    public class PossibilidadesDeJogada : Tabuleiro
    {
        public List<String> Casas { get; set; }
        public Peca PecaSelecionada { get; set; }

        public PossibilidadesDeJogada(Tabuleiro tabuleiro, Peca peca)
        {
            Casas = new List<String>();
            this.Mapeamento = tabuleiro.Mapeamento;
            this.PecaSelecionada = peca;
        }

        private List<String> VerificarPossibilidades()
        {
            switch (PecaSelecionada.Tipo)
            {
                case TipoPeca.Peao:
                    Casas = VerificarPossibilidadesPeao(PecaSelecionada.Coordenada);
                    break;
                
                case TipoPeca.Torre:
                    VerificarPossibilidadesTorre(PecaSelecionada.Coordenada);
                    break;
                
                case TipoPeca.Bispo:
                    VerificarPossibilidadesBispo(PecaSelecionada.Coordenada);
                    break;
                
                case TipoPeca.Cavalo:
                    VerificarPossibilidadesCavalo(PecaSelecionada.Coordenada);
                    break;
                
                case TipoPeca.Rainha:
                    VerificarPossibilidadesRainha(PecaSelecionada.Coordenada);
                    break;
                
                case TipoPeca.Rei:
                    VerificarPossibilidadesRei(PecaSelecionada.Coordenada);
                    break;
            }

            return Casas;
        }

        private void VerificarPossibilidadesRei(Coordenada coordenada)
        {
            throw new NotImplementedException();
        }

        private void VerificarPossibilidadesRainha(Coordenada coordenada)
        {
            throw new NotImplementedException();
        }

        private void VerificarPossibilidadesCavalo(Coordenada coordenada)
        {
            throw new NotImplementedException();
        }

        private void VerificarPossibilidadesBispo(Coordenada coordenada)
        {
            throw new NotImplementedException();
        }

        private void VerificarPossibilidadesTorre(Coordenada coordenada)
        {
            throw new NotImplementedException();
        }

        private List<String> VerificarPossibilidadesPeao(Coordenada coordenada)
        {
            var casasPossiveis = new List<String>();

            if (Mapeamento[coordenada.Linha + 1, coordenada.Coluna].Peca == null && Mapeamento[coordenada.Linha + 1, coordenada.Coluna].Indice != null)
            {
                casasPossiveis.Add(Mapeamento[coordenada.Linha + 1, coordenada.Coluna].Indice);
            }
            if (Mapeamento[coordenada.Linha + 1, coordenada.Coluna + 1].Peca == null && Mapeamento[coordenada.Linha + 1, coordenada.Coluna + 1].Indice != null)
            {
                casasPossiveis.Add(Mapeamento[coordenada.Linha + 1, coordenada.Coluna +1].Indice);
            }
            if (Mapeamento[coordenada.Linha + 1, coordenada.Coluna - 1 ].Peca == null && Mapeamento[coordenada.Linha + 1, coordenada.Coluna - 1].Indice != null)
            {
                casasPossiveis.Add(Mapeamento[coordenada.Linha + 1, coordenada.Coluna - 1].Indice);
            }

            return casasPossiveis;
        }
    }
}
