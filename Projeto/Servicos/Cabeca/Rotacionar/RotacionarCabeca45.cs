using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.ViewModel;
using System;

namespace R.O.B.O.Servicos.Cabeca.Rotacionar
{
    public class RotacionarCabeca45 : IRotacionarCabeca
    {
        public bool MovimentoValido(RotacionarCabecaViewModel rotacao)
        {
            return rotacao.Eh45 && !rotacao.Ehlimite90 && !rotacao.InclinacaoEhParaBaixo;
        }

        public EstadoModel Mover(RotacionarCabecaViewModel rotacao)
        {
            string Comando()
            {

                return rotacao.EstadoAtualRotacao switch
                {
                    Rotacao.Rotacao45 => "-10px/2px",
                    Rotacao.EmRepouso => "15px/2px",                    
                    Rotacao.RotacaoNegativa45 => "35%/35%",
                    Rotacao.RotacaoNegativa90 => "100px/25px",
                    Rotacao.Rotacao90 => "15px/2px",
                    _ => throw new Exception("Erro ao gerar comando")
                };
            }

            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(Comando());
            estadoAtual.AddEstadoAtual((int)rotacao.EstadoAtualRotacao + 1);

            return estadoAtual;
        }
    }
}
