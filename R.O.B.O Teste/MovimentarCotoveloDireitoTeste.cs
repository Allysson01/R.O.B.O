using R.O.B.O.Models;
using R.O.B.O.Servicos.Membros;
using R.O.B.O.Servicos.Membros.Contrair;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;
using Xunit;

namespace R.O.B.O_Teste
{
    public class MovimentarCotoveloDireitoTeste
    {
        [Fact]
        public void Contrair_CotoveloDireito_LeveContraido_EstadoEmRepouso()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.LeveContraido,
                EstadoAtualCotovelo = O.Enum.Contrair.EmRepouso,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "-37px/-35deg/-120px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Contrair_CotoveloDireito_Contraido_EstadoLeveContraido()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.Contraido,
                EstadoAtualCotovelo = O.Enum.Contrair.LeveContraido,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "-63px/-80deg/-75px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Contrair_CotoveloDireito_ForteContraido_EstadoContraido()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.ForteContraido,
                EstadoAtualCotovelo = O.Enum.Contrair.Contraido,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "-60px/-120deg/-30px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Contrair_CotoveloDireito_Contraido_EstadoForteContraido()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.Contraido,
                EstadoAtualCotovelo = O.Enum.Contrair.ForteContraido,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "-63px/-80deg/-75px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Contrair_CotoveloDireito_LeveContraido_EstadoContraido()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.LeveContraido,
                EstadoAtualCotovelo = O.Enum.Contrair.Contraido,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "-37px/-35deg/-120px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Contrair_CotoveloDireito_EmRepouso_EstadoLeveContraido()
        {
            var movimentosValidos = new List<IContrairCotovelo>
            {
                new EmRepouso(),
                new LeveContraido(),
                new Contraido(),
                new ForteContraido(),
            };

            var movimento = new ContrairCotoveloViewModel
            {
                Contrair = O.Enum.Contrair.EmRepouso,
                EstadoAtualCotovelo = O.Enum.Contrair.LeveContraido,
            };

            var validador = new ValidadorDireito(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "0/0/-140px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

    }
}
