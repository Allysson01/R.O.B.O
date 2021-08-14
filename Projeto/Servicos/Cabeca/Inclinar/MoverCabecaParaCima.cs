using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.ViewModel;
using System;

namespace R.O.B.O.Servicos.Cabeca
{
    public class MoverCabecaParaCima : IMoverCabeca
    {
        public bool MovimentoValido(InclinarCabecaViewModel inclinacao)
        {
            return inclinacao.EhParaCima && !inclinacao.LimiteParaCima;
        }

        public EstadoModel Mover(InclinarCabecaViewModel inclinacao)
        {
            string Comando()
            {                
                return inclinacao.EstadoAtualInclinacao switch
                {
                    Inclinacao.EmRepouso => "0%/10%",
                    Inclinacao.ParaBaixo => "15%/40%",
                    _ => throw new Exception("Erro ao gerar comando")
                };
            }

            var estadoAtual = new EstadoModel();

            estadoAtual.AddEstadoAtual((int)inclinacao.EstadoAtualInclinacao - 1);
            estadoAtual.AddComando(Comando());

            return estadoAtual;
        }
    }
}
