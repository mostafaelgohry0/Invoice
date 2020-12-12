using Microsoft.EntityFrameworkCore;
using MvcPlay.Models;

namespace MvcPlay.Data
{
    public class MvcPlayContext : DbContext
    {
        public MvcPlayContext (DbContextOptions<MvcPlayContext> options)
            : base(options)
        {
        }

        public DbSet<Play> Play { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}