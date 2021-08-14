using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.Servicos.Membros.Maos.Esquerdo.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Membros.Maos.Esquerdo
{
    public class ComandosMaoEsquerda : IComandosMaoEsquerda
    {
        public EstadoModel RotacionarMaoEsquerda(RotacionarMaoViewModel mao)
        {
            var movimentosValidos = new List<IRotacionarMao>
            {
                new RotacionarNegativo90(),
                new RotacionarNegativo45(),
                new EmRepousoMaoEsquerda(),
                new Rotacionar45(),
                new Rotacionar90(),
                new Rotacionar135(),
                new Rotacionar180(),
            };

            var validador = new ValidadorMaoEsquerda(movimentosValidos);

            return validador.Mover(mao);
        }
    }
}
