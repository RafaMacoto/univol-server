using univol_server.models;

namespace univol_server.Services.Interfaces
{
    public interface IPedidoService
    {

        Task<IEnumerable<Pedido>> ObterTodosAsync();
        Task<Pedido?> ObterPorIdAsync(long id);
        Task CriarAsync(Pedido pedido);
        Task AtualizarAsync(Pedido pedido);
        Task DeletarAsync(long id);
    }
}
