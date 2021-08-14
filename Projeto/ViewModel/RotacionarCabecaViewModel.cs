using R.O.B.O.Enum;
using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.ViewModel
{
    public class RotacionarCabecaViewModel
    {
        [Range(0, 2)]
        public Inclinacao EstadoAtualInclinacao { get; set; }


        [Range(-2, 4)]
        public Rotacao MovimentoRotacao { get; set; }
        [Range(-2, 4)]
        public Rotacao EstadoAtualRotacao { get; set; }

        public bool InclinacaoEhParaBaixo { get => EstadoAtualInclinacao == Inclinacao.ParaBaixo; }        
        public bool Eh45 { get => MovimentoRotacao == Rotacao.Rotacao45; }
        public bool EhNegativa45 { get => MovimentoRotacao == Rotacao.RotacaoNegativa45; }
        public bool EhlimiteNegativa90 { get => MovimentoRotacao == Rotacao.RotacaoNegativa90; }
        public bool Ehlimite90 { get => EstadoAtualRotacao == Rotacao.Rotacao90; }
    }
}
