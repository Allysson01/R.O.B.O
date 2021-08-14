using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Cabeca.Rotacionar
{
    public class ComandoRotacionarCabeca : IComandoRotacionarCabeca
    {
        public EstadoModel MovimentarCabeca(RotacionarCabecaViewModel rotacao)
        {
            var movimentosValidos = new List<IRotacionarCabeca>
            {
                new RotacionarCabeca45(),
                new RotacionarCabecaNegativo45()
            };

            var validador = new ValidadorRotacao(movimentosValidos);

            return validador.Mover(rotacao);
        }
    }
}
