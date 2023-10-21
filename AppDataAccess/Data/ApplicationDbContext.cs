using AppModel.Models;
using Microsoft.EntityFrameworkCore; //Ekledik

namespace AppDataAccess.Data
{
    public class ApplicationDbContext : DbContext //Public Yaptık
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Depolar> Depolars { get; set; }

    }
}
