using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using XadrezWpf.Classes;
using XadrezWpf.Classes.Enumerators;

namespace XadrezWpf.Pieces
{
    public partial class Peca : UserControl
    {
        public int Id { get; set; }
        public TipoPeca Tipo { get; set; }
        public CorDaPeca Cor { get; set; }
        public string PosicaoAtual { get; set; }
        public Coordenada Coordenada { get; set; }
        public bool PecaCapturada { get; set; }

        public Peca(int id, TipoPeca tipo, string posicaoAtual, CorDaPeca cor)
        {
            InitializeComponent();

            Id = id;
            Tipo = tipo;
            PosicaoAtual = posicaoAtual;
            Cor = cor;

            RecuperarImagem();
        }

        private void RecuperarImagem()
        {
            string path = string.Empty;

            if(this.Cor == CorDaPeca.Branca)
                path = String.Format(@"./img/PecasBrancas/{0}.png", Tipo.ToString());
            else
                path = String.Format(@"./img/PecasPretas/{0}.png", Tipo.ToString());

            PecaImg.Source = new BitmapImage(new Uri(path, UriKind.Relative));
        }
    }
}
