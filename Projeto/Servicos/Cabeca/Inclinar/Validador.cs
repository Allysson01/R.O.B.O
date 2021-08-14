using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.O.B.O.Servicos.Cabeca
{
    public class Validador
    {
        readonly IEnumerable<IMoverCabeca> _mover;
        public Validador(IEnumerable<IMoverCabeca> mover)
        {
            _mover = mover;
        }

        public EstadoModel Mover(InclinarCabecaViewModel inclinacao)
        {
            try
            {
                var resultado = new EstadoModel();                
                var movimento = _mover.Where(x => x.MovimentoValido(inclinacao)).ToList();

                foreach (var item in movimento)
                {
                    resultado = item.Mover(inclinacao);                    
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
