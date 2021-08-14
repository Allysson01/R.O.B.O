using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using R.O.B.O.Servicos.Cabeca.Interface;
using R.O.B.O.Servicos.Cabeca.Rotacionar.Interface;
using R.O.B.O.Servicos.Membros.Contrair.Esquerdo.Interface;
using R.O.B.O.Servicos.Membros.Contrair.Interface;
using R.O.B.O.Servicos.Membros.Maos.Direito.Interface;
using R.O.B.O.Servicos.Membros.Maos.Esquerdo.Interface;
using R.O.B.O.ViewModel;
using System;

namespace R.O.B.O.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        readonly IComandosCabeca _inclinarCabeca;
        readonly IComandoRotacionarCabeca _rotacionarCabeca;
        readonly IComandosCotoveloDireito _contrairCotoveloDireito;
        readonly IComandosCotoveloEsquerdo _contrairCotoveloEsquerdo;
        readonly IComandosMaoDireita _comandosMaoDireita;
        readonly IComandosMaoEsquerda _comandosMaoEsquerda;
        public RoboController(IComandosCabeca inclinarCabeca,
                              IComandoRotacionarCabeca rotacionarCabeca,
                              IComandosCotoveloDireito contrairCotoveloDireito,
                              IComandosCotoveloEsquerdo contrairCotoveloEsquerdo,
                              IComandosMaoDireita comandosMaoDireita,
                              IComandosMaoEsquerda comandosMaoEsquerda)
        {
            _inclinarCabeca = inclinarCabeca;
            _rotacionarCabeca = rotacionarCabeca;
            _contrairCotoveloDireito = contrairCotoveloDireito;
            _contrairCotoveloEsquerdo = contrairCotoveloEsquerdo;
            _comandosMaoDireita = comandosMaoDireita;
            _comandosMaoEsquerda = comandosMaoEsquerda;
        }


        #region Inicializar Robo
        [HttpGet]
        [Route("Inicializa")]
        [EnableCors("Livre")]
        public IActionResult InicializaRobo()
        {
            return Ok(true);
        }
        #endregion

        #region Movimentar Cabeca
        [HttpPost]
        [Route("InclinarCabeca")]
        [EnableCors("Livre")]
        public IActionResult InclinarCabeca([FromBody] InclinarCabecaViewModel inclinacao)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_inclinarCabeca.MovimentarCabeca(inclinacao));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar cabeça");
            }
        }

        [HttpPost]
        [Route("RotacionarCabeca")]
        [EnableCors("Livre")]
        public IActionResult RotacionarCabeca([FromBody] RotacionarCabecaViewModel rotacionar)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_rotacionarCabeca.MovimentarCabeca(rotacionar));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar cabeça");
            }
        }


        #endregion

        #region Movimentar mebro
        [HttpPost]
        [Route("ContrairCotoveloDireito")]
        [EnableCors("Livre")]
        public IActionResult ContrairCotoveloDireito([FromBody] ContrairCotoveloViewModel contrair)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_contrairCotoveloDireito.ContrairCotovelo(contrair));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar cotovelo");
            }
        }

        [HttpPost]
        [Route("ContrairCotoveloEsquerdo")]
        [EnableCors("Livre")]
        public IActionResult ContrairCotoveloEsquerdo([FromBody] ContrairCotoveloViewModel contrair)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_contrairCotoveloEsquerdo.ContrairCotovelo(contrair));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar cotovelo");
            }
        }

        [HttpPost]
        [Route("RotacionarMaoDireita")]
        [EnableCors("Livre")]
        public IActionResult RotacionarMaoDireita([FromBody] RotacionarMaoViewModel mao)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_comandosMaoDireita.RotacionarMaoDireita(mao));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar mão");
            }
        }

        [HttpPost]
        [Route("RotacionarMaoEsquerda")]
        [EnableCors("Livre")]
        public IActionResult RotacionarMaoEsquerda([FromBody] RotacionarMaoViewModel mao)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(_comandosMaoEsquerda.RotacionarMaoEsquerda(mao));

                return NoContent();
            }
            catch (Exception ex)
            {
                _ = ex;
                throw new Exception("Erro ao movimentar mão");
            }
        }
        #endregion
    }
}
