using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.O.B.O.Servicos.Cabeca.Rotacionar
{
    public class ValidadorRotacao
    {
        readonly IEnumerable<IRotacionarCabeca> _mover;
        public ValidadorRotacao(IEnumerable<IRotacionarCabeca> mover)
        {
            _mover = mover;
        }

        public EstadoModel Mover(RotacionarCabecaViewModel rotacao)
        {
            try
            {
                var resultado = new EstadoModel();                
                var movimento = _mover.Where(x => x.MovimentoValido(rotacao)).ToList();

                foreach (var item in movimento)
                {
                    resultado = item.Mover(rotacao);                    
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
