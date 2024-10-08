using Aplicacao.DTO;
using Aplicacao.Interfaces;
using Aplicacao.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoServicoApp _pedidoServicoApp;
        public PedidoController(IPedidoServicoApp pedidoServicoApp)
        {
            _pedidoServicoApp = pedidoServicoApp;
        }

        [HttpPost("Criar")]
        public async Task<IActionResult> Criar([FromBody] PedidoModeloAtualizar pedidoModeloCriar)
        {
            await _pedidoServicoApp.CriarAsync(pedidoModeloCriar);
            return Ok();
        }

        [HttpPost("Atualizar")]
        public async Task<IActionResult> Atualizar([FromBody] PedidoModeloAtualizar pedidoModeloAtualizar)
        {
            await _pedidoServicoApp.AtualizarAsync(pedidoModeloAtualizar);
            return Ok();
        }

        [HttpGet("Excluir")]
        public async Task<IActionResult> Excluir([FromQuery] int? id)
        {
            await _pedidoServicoApp.ExcluirAsync(id);
            return Ok();
        }

        [HttpGet("Pedidos")]
        [ProducesResponseType(typeof(List<PedidoModeloListar>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Listar()
        {
            var pedidos = await _pedidoServicoApp.ListarAsync();
            return Ok(pedidos);
        }
    }
}
