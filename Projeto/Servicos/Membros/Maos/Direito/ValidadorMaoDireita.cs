using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.O.B.O.Servicos.Membros.Maos.Direito
{
    public class ValidadorMaoDireita
    {
        readonly IEnumerable<IRotacionarMao> _mao;
        public ValidadorMaoDireita(IEnumerable<IRotacionarMao> mao)
        {
            _mao = mao;
        }

        public EstadoModel Mover(RotacionarMaoViewModel mao)
        {
            try
            {
                var resultado = new EstadoModel();
                var movimento = _mao.Where(x => x.MovimentoValido(mao)).ToList();

                foreach (var item in movimento)
                {
                    resultado = item.Mover();
                }

                return resultado;
            }
            catch (Exception ex)
            {
                _ = ex;
                throw;
            }
        }
    }
}
