using univol_server.models;

namespace univol_server.Services.Interfaces
{
    public interface IUsuarioService
    {

        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task<Usuario?> ObterPorIdAsync(long id);
        Task CriarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task DeletarAsync(long id);
    }
}
