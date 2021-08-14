using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;


namespace R.O.B.O.Servicos.Membros
{
    public class LeveContraido : IContrairCotovelo
    {
        public bool MovimentoValido(ContrairCotoveloViewModel contrair)
        {
            return contrair.EhLeveContraido;
        }

        public EstadoModel Mover()
        {
            const string comando = "-37px/-35deg/-120px";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)Enum.Contrair.LeveContraido);

            return estadoAtual;
        }
    }
}
