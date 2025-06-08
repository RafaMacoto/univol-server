using Microsoft.EntityFrameworkCore;
using univol_server.data;
using univol_server.models;
using univol_server.Services.Interfaces;

namespace univol_server.Services
{
    public class OrganizacaoService : IOrganizacaoService
    {

        private readonly AppDbContext _context;

        public OrganizacaoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Organizacao>> ObterTodosAsync()
        {
            return await _context.Organizacoes.ToListAsync();
        }

        public async Task<Organizacao?> ObterPorIdAsync(long id)
        {
            return await _context.Organizacoes.FindAsync(id);
        }

        public async Task CriarAsync(Organizacao organizacao)
        {
            _context.Organizacoes.Add(organizacao);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Organizacao organizacao)
        {
            _context.Organizacoes.Update(organizacao);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarAsync(long id)
        {
            var organizacao = await _context.Organizacoes.FindAsync(id);
            if (organizacao != null)
            {
                _context.Organizacoes.Remove(organizacao);
                await _context.SaveChangesAsync();
            }
        }
    }
}
