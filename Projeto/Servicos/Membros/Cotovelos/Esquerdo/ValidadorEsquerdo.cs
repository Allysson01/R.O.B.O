using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.O.B.O.Servicos.Membros.Contrair
{
    public class ValidadorEsquerdo
    {
        readonly IEnumerable<IContrairCotovelo> _contrair;
        public ValidadorEsquerdo(IEnumerable<IContrairCotovelo> contrair)
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
