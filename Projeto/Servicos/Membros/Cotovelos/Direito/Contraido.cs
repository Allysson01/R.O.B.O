using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros
{
    public class Contraido : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhContraido;
        }

        public EstadoModel Mover()
        {
            const string comando = "-63px/-80deg/-75px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.Contraido);

            return estadoAtual;
        }
    }
}
