using R.O.B.O.Models;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Maos.Esquerdo.Interface
{
    public interface IComandosMaoEsquerda
    {
        EstadoModel RotacionarMaoEsquerda(RotacionarMaoViewModel contrair);
    }
}
