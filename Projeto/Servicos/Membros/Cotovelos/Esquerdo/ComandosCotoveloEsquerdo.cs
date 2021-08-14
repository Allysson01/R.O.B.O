using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Membros.Contrair.Esquerdo
{
    public class ComandosCotoveloEsquerdo : IComandosCotoveloEsquerdo
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

            var validador = new ValidadorEsquerdo(movimentosValidos);

            return validador.Mover(contrair);
        }
    }
}
