using R.O.B.O.Models;
using R.O.B.O.Servicos.Cabeca;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.Servicos.Cabeca.Rotacionar;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.ViewModel;
using System.Collections.Generic;
using Xunit;

namespace R.O.B.O_Teste
{
    public class MovimentosCabecaTeste
    {
        [Fact]
        public void Inclinar_Cabeca_ParaBaixo_EstadoEmRepouso()
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
        public void Inclinar_Cabeca_ParaBaixo_EstadoParaCima()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaBaixo,
                EstadoAtualInclinacao = O.Enum.Inclinacao.ParaCima,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "15%/40%";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Inclinar_Cabeca_ParaBaixo_EstadoParaBaixo()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaBaixo,
                EstadoAtualInclinacao = O.Enum.Inclinacao.ParaBaixo,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = null;

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Inclinar_Cabeca_ParaCima_EstadoEmRepouso()
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

        [Fact]
        public void Inclinar_Cabeca_ParaCima_EstadoParaBaixo()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaCima,
                EstadoAtualInclinacao = O.Enum.Inclinacao.ParaBaixo,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            var valorPadrao = "15%/40%";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Inclinar_Cabeca_ParaCima_EstadoParaCima()
        {
            var movimentosValidos = new List<IMoverCabeca>
            {
                new MoverCabecaParaBaixo(),
                new MoverCabecaParaCima(),
            };

            var movimento = new InclinarCabecaViewModel
            {
                MovimentoInclinacao = O.Enum.Inclinacao.ParaCima,
                EstadoAtualInclinacao = O.Enum.Inclinacao.ParaCima,
            };

            var validador = new Validador(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = null;

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Rotacionar_Cabeca_45_EstadoEmRepouso()
        {
            var movimentosValidos = new List<IRotacionarCabeca>
            {
                new RotacionarCabeca45(),
                new RotacionarCabecaNegativo45(),
            };

            var movimento = new RotacionarCabecaViewModel
            {
                MovimentoRotacao = O.Enum.Rotacao.Rotacao45,
                EstadoAtualRotacao = O.Enum.Rotacao.EmRepouso,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new ValidadorRotacao(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = "15px/2px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void Rotacionar_Cabeca_90_EstadoRotacao45()
        {
            var movimentosValidos = new List<IRotacionarCabeca>
            {
                new RotacionarCabeca45(),
                new RotacionarCabecaNegativo45(),
            };

            var movimento = new RotacionarCabecaViewModel
            {
                MovimentoRotacao = O.Enum.Rotacao.Rotacao45,
                EstadoAtualRotacao = O.Enum.Rotacao.Rotacao45,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new ValidadorRotacao(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = "-10px/2px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        #region Exemplo do mau uso que o switch pode trazer
        /*switchs e ifs são usuais e muito válidos em alguns casos,
         porém no momento que existem muitas condicionais, erros podem
         ocorrem onde menos se espera. 
        
        Olhando um pouco melhor, é possível ver a solução sem grande dificuldade, mas 
        o melhor é não dependermos de muitas condicionais...*/

        [Fact]
        public void NaoVaiPassar_Rotacionar_Cabeca_45_EstadoRotacao90()
        {
            var movimentosValidos = new List<IRotacionarCabeca>
            {
                new RotacionarCabeca45(),
                new RotacionarCabecaNegativo45(),
            };

            var movimento = new RotacionarCabecaViewModel
            {
                MovimentoRotacao = O.Enum.Rotacao.Rotacao45,
                EstadoAtualRotacao = O.Enum.Rotacao.Rotacao90,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new ValidadorRotacao(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = "-10px/2px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }

        [Fact]
        public void EssePassa_Rotacionar_Cabeca_Negativo45_EstadoRotacao90()
        {
            var movimentosValidos = new List<IRotacionarCabeca>
            {
                new RotacionarCabeca45(),
                new RotacionarCabecaNegativo45(),
            };

            var movimento = new RotacionarCabecaViewModel
            {
                MovimentoRotacao = O.Enum.Rotacao.RotacaoNegativa45,
                EstadoAtualRotacao = O.Enum.Rotacao.Rotacao90,
                EstadoAtualInclinacao = O.Enum.Inclinacao.EmRepouso,
            };

            var validador = new ValidadorRotacao(movimentosValidos);

            var resultado = validador.Mover(movimento);

            string valorPadrao = "15px/2px";

            Assert.Equal(valorPadrao, resultado.Comando);
            Assert.IsType<EstadoModel>(resultado);
        }
        #endregion
    }
}
