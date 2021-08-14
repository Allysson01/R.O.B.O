using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.ViewModel;

namespace R.O.B.O.Servicos.Membros.Maos.Esquerdo
{
    public class Rotacionar45 : IRotacionarMao
    {
        public bool MovimentoValido(RotacionarMaoViewModel mao)
        {
            return mao.Eh45;
        }

        public EstadoModel Mover()
        {
            const string comando = "-85deg";
            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(comando);
            estadoAtual.AddEstadoAtual((int)RotacaoMao.Rotacao45);

            return estadoAtual;
        }
    }
}
