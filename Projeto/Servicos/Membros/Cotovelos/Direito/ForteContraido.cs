using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros
{
    public class ForteContraido : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhForteContraido;
        }

        public EstadoModel Mover()
        {
            const string comando = "-60px/-120deg/-30px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.ForteContraido);

            return estadoAtual;
        }
    }
}
