using System.Collections.Generic;
using XadrezWpf.Pieces;

namespace XadrezWpf.Classes
{
    public class ListaDePecas
    {
        public List<Peca>? PeoesBrancos { get; set; }
        public List<Peca>? PecasEspeciaisBrancas { get; set; }
        public List<Peca>? PecasEspeciaisPretas { get; set; }
        public List<Peca>? PeoesPretos { get; set; }
    }
}
