using XadrezWpf.Classes.Enumerators;
using XadrezWpf.Pieces;

namespace XadrezWpf.Classes
{
    public class Posicao
    {
      public Peca Peca { get; set; }
      public string Indice { get; set; }
      public CorDaCasa Cor { get; set; }

      public Posicao(string indice, CorDaCasa cor) 
      { 
         Indice = indice;
         Cor = cor;
      }
    }
}
