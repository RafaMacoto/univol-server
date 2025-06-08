using Microsoft.AspNetCore.Mvc;
using univol_server.models;
using univol_server.Services.Interfaces;

namespace univol_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizacaoController : ControllerBase
    {
        private readonly IOrganizacaoService _organizacaoService;

        public OrganizacaoController(IOrganizacaoService organizacaoService)
        {
            _organizacaoService = organizacaoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var organizacoes = await _organizacaoService.ObterTodosAsync();
            return Ok(organizacoes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var organizacao = await _organizacaoService.ObterPorIdAsync(id);
            if (organizacao == null) return NotFound();
            return Ok(organizacao);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Organizacao organizacao)
        {
            await _organizacaoService.CriarAsync(organizacao);
            return CreatedAtAction(nameof(Get), new { id = organizacao.Id }, organizacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Organizacao organizacao)
        {
            if (id != organizacao.Id) return BadRequest();
            await _organizacaoService.AtualizarAsync(organizacao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _organizacaoService.DeletarAsync(id);
            return NoContent();
        }
    }
}
