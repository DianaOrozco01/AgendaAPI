using Microsoft.EntityFrameworkCore;
using AgendaAPI.Models;

namespace AgendaAPI.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options)
            : base(options)
        {
        }

        public DbSet<Agenda> Agenda { get; set; }    // <-- Necesario
    }
}
