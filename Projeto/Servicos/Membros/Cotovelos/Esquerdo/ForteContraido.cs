using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Contrair.Esquerdo
{
    public class ForteContraido : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhForteContraido;
        }

        public EstadoModel Mover(ContrairCotoveloViewModel contrair)
        {
            const string comando = "-60px/120deg/80px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.ForteContraido);

            return estadoAtual;
        }
    }
}
