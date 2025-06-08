namespace univol_server.models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Localizacao { get; set; }

        public List<string> Habilidades { get; set; } = new List<string>();
    }
}
