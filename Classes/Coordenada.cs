using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezWpf.Classes
{
    public class Coordenada
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Coordenada() { }

        public Coordenada(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
    }
}
