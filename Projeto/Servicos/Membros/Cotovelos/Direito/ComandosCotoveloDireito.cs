using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Membros.Contrair
{
    public class ComandosCotoveloDireito : IComandosCotoveloDireito
    {
        public EstadoModel ContrairCotovelo(ContrairCotoveloViewModel contrair)
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var validador = new ValidadorDireito(movimentosValidos);

            return validador.Mover(contrair);
        }
    }
}
