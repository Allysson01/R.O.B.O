using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Cabeca.Interface
{
    public interface IComandosCabeca
    {
        EstadoModel MovimentarCabeca(InclinarCabecaViewModel inclinacao);
    }
}
