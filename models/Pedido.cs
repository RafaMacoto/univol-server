namespace univol_server.models
{
    public class Pedido
    {

        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Prioridade Prioridade { get; set; } 
        public DateTime DataCriacao { get; set; } = DateTime.Now;

       
        public int OrganizacaoId { get; set; }

        
        public Organizacao Organizacao { get; set; }

    }
}
