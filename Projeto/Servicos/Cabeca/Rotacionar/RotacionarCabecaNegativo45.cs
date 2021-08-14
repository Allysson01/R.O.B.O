using R.O.B.O.Enum;
using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.ViewModel;
using System;

namespace R.O.B.O.Servicos.Cabeca.Rotacionar
{
    public class RotacionarCabecaNegativo45 : IRotacionarCabeca
    {
        public bool MovimentoValido(RotacionarCabecaViewModel rotacao)
        {
            return rotacao.EhNegativa45 && !rotacao.EhlimiteNegativa90;
        }

        public EstadoModel Mover(RotacionarCabecaViewModel rotacao)
        {
            string Comando()
            {
                return rotacao.EstadoAtualRotacao switch
                {
                    Rotacao.EmRepouso => "100px/25px",
                    Rotacao.RotacaoNegativa45 => "125px/25px",
                    Rotacao.Rotacao90 => "15px/2px",
                    Rotacao.Rotacao45 => "35%/35%",
                    _ => throw new Exception("Erro ao gerar comando")
                };
            }

            var estadoAtual = new EstadoModel();

            estadoAtual.AddComando(Comando());
            estadoAtual.AddEstadoAtual((int)rotacao.EstadoAtualRotacao - 1);

            return estadoAtual;
        }
    }
}
