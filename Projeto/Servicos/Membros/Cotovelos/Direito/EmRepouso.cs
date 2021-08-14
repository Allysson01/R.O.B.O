using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros
{
    public class EmRepouso : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhEmRepouso;
        }

        public EstadoModel Mover()
        {
            const string comando = "0/0/-140px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.EmRepouso);

            return estadoAtual;
        }
    }
}
