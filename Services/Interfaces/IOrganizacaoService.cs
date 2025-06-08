using univol_server.models;

namespace univol_server.Services.Interfaces
{
    public interface IOrganizacaoService
    {

        Task<IEnumerable<Organizacao>> ObterTodosAsync();
        Task<Organizacao?> ObterPorIdAsync(long id);
        Task CriarAsync(Organizacao organizacao);
        Task AtualizarAsync(Organizacao organizacao);
        Task DeletarAsync(long id);
    }
}
