namespace univol_server.models
{
    public class Organizacao
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
