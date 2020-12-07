using calculajuros.Interfaces;
using calculajuros.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace calculajuros.Controllers
{
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculoJurosService _calculoJurosService;

        public CalculaJurosController(ICalculoJurosService calculoJurosService)
        {
            _calculoJurosService = calculoJurosService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("calculaJuros")]
        public async Task<IActionResult> ObterCalculoJuros([FromQuery] CalculoJurosViewModel calculoJurosViewModel)
        {           
            return Ok(await _calculoJurosService.ObterCalculoJuros(calculoJurosViewModel.ValorInicial, calculoJurosViewModel.Meses));                  
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("showmethecode")]
        public IActionResult ObterCodigo()
        {
            return Ok(_calculoJurosService.ObterCodigo());
        }
    }
}