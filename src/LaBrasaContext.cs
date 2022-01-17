using LaBrasa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaBrasa.Shared
{
    public class LaBrasaContext : DbContext
    {
        public LaBrasaContext(DbContextOptions<LaBrasaContext> opt) : base(opt) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        
    }
}
