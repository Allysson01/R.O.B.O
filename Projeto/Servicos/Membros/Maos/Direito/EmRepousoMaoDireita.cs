using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Maos.Direito
{
    public class EmRepousoMaoDireita : IRotacionarMao
    {
        public bool MovimentoValido(RotacionarMaoViewModel mao)
        {
            return mao.EhEmRepouso;
        }

        public EstadoModel Mover()
        {
            const string comando = "55deg";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)RotacaoMao.EmRepouso);

            return estadoAtual;
        }
    }
}
