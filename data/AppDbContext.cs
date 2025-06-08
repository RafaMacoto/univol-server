using Microsoft.EntityFrameworkCore;
using univol_server.models;

namespace univol_server.data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Organizacao> Organizacoes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Organizacao>().ToTable("t_uv_organizacoes");
            modelBuilder.Entity<Pedido>().ToTable("t_uv_pedidos");
            modelBuilder.Entity<Usuario>().ToTable("t_uv_usuarios");

            
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Organizacao)
                .WithMany(o => o.Pedidos)
                .HasForeignKey(p => p.OrganizacaoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pedido>()
                .Property(p => p.Prioridade)
                .HasConversion<string>();


            modelBuilder.Entity<Usuario>()
                .Property(u => u.Habilidades)
                .HasConversion(
                    v => System.Text.Json.JsonSerializer.Serialize(v, (System.Text.Json.JsonSerializerOptions?)null),
                    v => System.Text.Json.JsonSerializer.Deserialize<List<string>>(v, (System.Text.Json.JsonSerializerOptions?)null));
        }
    }
}
