using Microsoft.EntityFrameworkCore;
using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Interfejsi;

namespace OceneFilmova.BazaPodataka
{
    public class FilmoviDbContext : DbContext, IFilmoviDbContext
    {
        private const string KONEKCIONI_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmoviOcene;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DbSet<Film> Filmovi => Set<Film>();
        public DbSet<Tag> Tagovi  => Set<Tag>();
        public DbSet<Glumac> Glumci => Set<Glumac>();

        public FilmoviDbContext()
        {
        }
        public FilmoviDbContext(DbContextOptions<FilmoviDbContext> opcije) : base(opcije) { }

        protected override void OnConfiguring(DbContextOptionsBuilder izgradjivacOpcija)
        {
            izgradjivacOpcija.UseSqlServer(KONEKCIONI_STRING);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Glumac>().Ignore(glumac => glumac.PunoIme);
        }
    }
}
