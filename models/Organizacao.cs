namespace univol_server.models
{
    public class Organizacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
