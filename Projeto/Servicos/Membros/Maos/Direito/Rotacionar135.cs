using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Maos.Direito
{
    public class Rotacionar135 : IRotacionarMao
    {
        public bool MovimentoValido(RotacionarMaoViewModel mao)
        {
            return mao.Eh135;
        }

        public EstadoModel Mover()
        {
            const string comando = "170deg";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)RotacaoMao.Rotacao135);

            return estadoAtual;
        }
    }
}
