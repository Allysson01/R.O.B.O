using R.O.B.O.Enum;
using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.ViewModel
{
    public class ContrairCotoveloViewModel
    {

        [Range(0, 3)]
        public Contrair Contrair { get; set; }
        [Range(0, 3)]
        public Contrair EstadoAtualCotovelo { get; set; }

        public bool EhEmRepouso { get => Contrair == Contrair.EmRepouso && EstadoAtualCotovelo == Contrair.LeveContraido; }
        public bool EhLeveContraido { get => Contrair == Contrair.LeveContraido && (EstadoAtualCotovelo == Contrair.EmRepouso || EstadoAtualCotovelo == Contrair.Contraido); }
        public bool EhContraido { get => Contrair == Contrair.Contraido && (EstadoAtualCotovelo == Contrair.LeveContraido || EstadoAtualCotovelo == Contrair.ForteContraido); }
        public bool EhForteContraido { get => Contrair == Contrair.ForteContraido && EstadoAtualCotovelo == Contrair.Contraido; }
    }
}
