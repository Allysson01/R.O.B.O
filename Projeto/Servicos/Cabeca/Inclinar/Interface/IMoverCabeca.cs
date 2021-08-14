using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Cabeca.Interface
{
    public interface IMoverCabeca
    {
        bool MovimentoValido(InclinarCabecaViewModel movimento);

        EstadoModel Mover(InclinarCabecaViewModel movimento);
    }
}
