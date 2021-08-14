using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Cabeca.Rotacionar.Interface
{
    public interface IRotacionarCabeca
    {
        bool MovimentoValido(RotacionarCabecaViewModel rotacionar);

        EstadoModel Mover(RotacionarCabecaViewModel rotacionar);
    }
}
