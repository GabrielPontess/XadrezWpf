using XadrezWpf.Classes.Enumerators;

namespace XadrezWpf.Classes
{
    public class Ordenacao
    {
        public string[] OrdemLetrasTabuleiro { get; set; }
        public TipoPeca[] OrdemPecasEspeciais { get; set; }
        
        public Ordenacao()
        {
            OrdemLetrasTabuleiro = new string[]{ "a", "b", "c", "d", "e", "f", "g", "h" };

        OrdemPecasEspeciais = new TipoPeca[]{ TipoPeca.Torre, 
                                              TipoPeca.Cavalo, 
                                              TipoPeca.Bispo, 
                                              TipoPeca.Rainha, 
                                              TipoPeca.Rei, 
                                              TipoPeca.Bispo,
                                              TipoPeca.Cavalo,
                                              TipoPeca.Torre };
        }
    
    }
}
