using Aplicacao.DTO;
using Aplicacao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServicoApp _produtoServicoApp;
        public ProdutoController(IProdutoServicoApp produtoServicoApp)
        {
            _produtoServicoApp = produtoServicoApp;
        }

        [HttpGet("Listar")]
        [ProducesResponseType(typeof(List<ProdutoDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Listar()
        {
            var produtos = await _produtoServicoApp.ListarAsync();
            return Ok(produtos);
        }
    }
}
