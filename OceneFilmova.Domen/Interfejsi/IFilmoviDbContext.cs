using Microsoft.EntityFrameworkCore;
using OceneFilmova.Domen.Entieti;

namespace OceneFilmova.Domen.Interfejsi
{
    public interface IFilmoviDbContext
    {
        public DbSet<Film> Filmovi { get; }
        public DbSet<Tag> Tagovi { get; }
        public DbSet<Glumac> Glumci { get; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
