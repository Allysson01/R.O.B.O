using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Contrair.Esquerdo
{
    public class Contraido : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhContraido;
        }

        public EstadoModel Mover(ContrairCotoveloViewModel contrair)
        {
            const string comando = "-63px/80deg/125px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.Contraido);

            return estadoAtual;
        }
    }
}
