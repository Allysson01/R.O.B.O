using R.O.B.O.Enum;
using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.ViewModel
{
    public class InclinarCabecaViewModel
    {

        [Range(0, 2)]
        public Inclinacao MovimentoInclinacao { get; set; }
        [Range(0, 2)]
        public Inclinacao EstadoAtualInclinacao { get; set; }


        [Range(0, 4)]
        public Rotacao MovimentoRotacao { get; set; }
        [Range(0, 4)]
        public Rotacao EstadoAtualRotacao { get; set; }


        public bool LimiteParaCima { get => EstadoAtualInclinacao == Inclinacao.ParaCima; }
        public bool LimiteParaBaixo { get => EstadoAtualInclinacao == Inclinacao.ParaBaixo; }
        public bool EhParaCima { get => MovimentoInclinacao == Inclinacao.ParaCima; }
        public bool EhEmRepouso { get => MovimentoInclinacao == Inclinacao.EmRepouso; }
        public bool EhParaBaixo { get => MovimentoInclinacao == Inclinacao.ParaBaixo; }
        public bool Eh45 { get => MovimentoRotacao == Rotacao.Rotacao45; }
        public bool Ehlimite90 { get => EstadoAtualRotacao == Rotacao.Rotacao90; }
    }
}
