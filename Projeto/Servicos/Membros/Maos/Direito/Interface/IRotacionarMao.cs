using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Maos.Direito.Interface
{
    public interface IRotacionarMao
    {
        bool MovimentoValido(RotacionarMaoViewModel mao);

        EstadoModel Mover();
    }
}
