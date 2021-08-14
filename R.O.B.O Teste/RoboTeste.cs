using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;
using Xunit;

namespace R.O.B.O_Teste
{
    public class RoboTeste
    {
        [Fact]
        public void Inclinar_Cabeca_ParaBaixo()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaBaixo,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "40%/70%";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Inclinar_Cabeca_ParaCima()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaCima,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "0%/10%";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }
    }
}
