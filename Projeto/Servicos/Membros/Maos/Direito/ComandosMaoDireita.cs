using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Membros.Contrair
{
    public class ComandosMaoDireita : IComandosMaoDireita
    {
        public EstadoModel RotacionarMaoDireita(RotacionarMaoViewModel mao)
        {
            var movimentosValidos = new List<IRotacionarMao>
            {
                new RotacionarNegativo90(),
                new RotacionarNegativo45(),
                new EmRepousoMaoDireita(),
                new Rotacionar45(),
                new Rotacionar90(),
                new Rotacionar135(),
                new Rotacionar180(),
            };

            var validador = new ValidadorMaoDireita(movimentosValidos);

            return validador.Mover(mao);
        }
    }
}