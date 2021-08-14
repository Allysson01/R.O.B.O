using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.O.B.O.Servicos.Membros.Contrair
{
    public class ValidadorDireito
    {
        readonly IEnumerable<IContrairCotovelo> _contrair;
        public ValidadorDireito(IEnumerable<IContrairCotovelo> contrair)
        {
            _contrair = contrair;
        }

        public EstadoModel Mover(ContrairCotoveloViewModel inclinacao)
        {
            try
            {
                var resultado = new EstadoModel();                
                var movimento = _contrair.Where(x => x.MovimentoValido(inclinacao)).ToList();

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
