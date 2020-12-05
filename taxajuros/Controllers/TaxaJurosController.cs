using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using taxajuros.Interfaces;

namespace taxajuros.Controllers
{
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("taxaJuros")]
        public IActionResult ObterTaxaJuros()
        {
            return Ok(_taxaJurosService.ObterTaxaJuros());
        }
    }
}