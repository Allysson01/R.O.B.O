using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Contrair.Interface
{
    public interface IContrairCotovelo
    {
        bool MovimentoValido(ContrairCotoveloViewModel contrair);

        EstadoModel Mover();
    }
}
