using R.O.B.O.Enum;
using System.ComponentModel.DataAnnotations;

namespace R.O.B.O.ViewModel
{
    public class RotacionarMaoViewModel
    {

        [Range(-2, 4)]
        public RotacaoMao Rotacao { get; set; }
        [Range(-2, 4)]
        public RotacaoMao EstadoAtualRotacaoMao { get; set; }

        [Range(0, 3)]
        public Contrair EstadoAtualCotovelo { get; set; }

        public bool EhNegativo90 {
            get => Rotacao == RotacaoMao.RotacaoNegativa90
                && EstadoAtualCotovelo == Contrair.ForteContraido
                && (EstadoAtualRotacaoMao == RotacaoMao.RotacaoNegativa45);
        }

        public bool EhNegativo45 {
            get => Rotacao == RotacaoMao.RotacaoNegativa45
                   && EstadoAtualCotovelo == Contrair.ForteContraido
                   && (EstadoAtualRotacaoMao == RotacaoMao.EmRepouso || EstadoAtualRotacaoMao == RotacaoMao.RotacaoNegativa90);
        }

        public bool EhEmRepouso {
            get => Rotacao == RotacaoMao.EmRepouso
                   && EstadoAtualCotovelo == Contrair.ForteContraido
                   && (EstadoAtualRotacaoMao == RotacaoMao.Rotacao45 || EstadoAtualRotacaoMao == RotacaoMao.RotacaoNegativa45);
        }

        public bool Eh45 {
            get => Rotacao == RotacaoMao.Rotacao45
                   && EstadoAtualCotovelo == Contrair.ForteContraido
                   && (EstadoAtualRotacaoMao == RotacaoMao.EmRepouso || EstadoAtualRotacaoMao == RotacaoMao.Rotacao90);
        }
        public bool Eh90 {
            get => Rotacao == RotacaoMao.Rotacao90
                && EstadoAtualCotovelo == Contrair.ForteContraido
                && (EstadoAtualRotacaoMao == RotacaoMao.Rotacao45 || EstadoAtualRotacaoMao == RotacaoMao.Rotacao135);
        }

        public bool Eh135 {
            get => Rotacao == RotacaoMao.Rotacao135
                && EstadoAtualCotovelo == Contrair.ForteContraido
                && (EstadoAtualRotacaoMao == RotacaoMao.Rotacao90 || EstadoAtualRotacaoMao == RotacaoMao.Rotacao180);
        }

        public bool Eh180 {
            get => Rotacao == RotacaoMao.Rotacao180
                && EstadoAtualCotovelo == Contrair.ForteContraido
                && (EstadoAtualRotacaoMao == RotacaoMao.Rotacao135);
        }       
    }
}
