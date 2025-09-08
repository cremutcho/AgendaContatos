using Microsoft.EntityFrameworkCore;
using AgendaContatos.Models;

namespace AgendaContatos.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}
