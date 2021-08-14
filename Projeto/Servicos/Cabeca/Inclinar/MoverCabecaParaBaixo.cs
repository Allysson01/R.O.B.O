using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.ViewModel;
using System;

namespace R.O.B.O.Servicos.Cabeca
{
    public class MoverCabecaParaBaixo : IMoverCabeca
    {
        public bool MovimentoValido(InclinarCabecaViewModel inclinacao)
        {
            return inclinacao.EhParaBaixo && !inclinacao.LimiteParaBaixo;
        }

        public EstadoModel Mover(InclinarCabecaViewModel inclinacao)
        {
            string Comando()
            {                
                return inclinacao.EstadoAtualInclinacao switch
                {
                    Inclinacao.ParaCima => "15%/40%",
                    Inclinacao.EmRepouso => "40%/70%",
                    _ => throw new Exception("Erro ao gerar comando")
                };
            }

            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(Comando());
            estadoAtual.AddEstadoAtual((int)inclinacao.EstadoAtualInclinacao + 1);

            return estadoAtual;
        }
    }
}
