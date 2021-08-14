using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;

namespace R.O.B.O.Servicos.Cabeca
{
    public class ComandosCabeca : IComandosCabeca
    {
        public EstadoModel MovimentarCabeca(InclinarCabecaViewModel movimento)
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var validador = new Validador(movimentosValidos);

            return validador.Mover(movimento);
        }
    }
}
