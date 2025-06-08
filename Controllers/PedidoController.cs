using Microsoft.AspNetCore.Mvc;
using univol_server.models;
using univol_server.Services.Interfaces;

namespace univol_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pedidos = await _pedidoService.ObterTodosAsync();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var pedido = await _pedidoService.ObterPorIdAsync(id);
            if (pedido == null) return NotFound();
            return Ok(pedido);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pedido pedido)
        {
            await _pedidoService.CriarAsync(pedido);
            return CreatedAtAction(nameof(Get), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Pedido pedido)
        {
            if (id != pedido.Id) return BadRequest();
            await _pedidoService.AtualizarAsync(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _pedidoService.DeletarAsync(id);
            return NoContent();
        }
    }
}
