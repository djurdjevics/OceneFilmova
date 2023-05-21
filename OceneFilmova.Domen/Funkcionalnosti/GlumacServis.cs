using Microsoft.EntityFrameworkCore;
using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Interfejsi;

namespace OceneFilmova.Domen.Funkcionalnosti
{
    public class GlumacServis
    {
        private readonly IFilmoviDbContext _filmoviDbContext;

        public GlumacServis(IFilmoviDbContext filmoviDbContext)
        {
            _filmoviDbContext= filmoviDbContext;
        }

        public async Task<List<Glumac>> PreuzmiGlumce()
        {
            return await _filmoviDbContext.Glumci.ToListAsync();
        }

        public async Task DodajGlumca(Glumac glumacZaDodati)
        {
            _filmoviDbContext.Glumci.Add(glumacZaDodati);
            await _filmoviDbContext.SaveChangesAsync();
        }

        public async Task ObrisiGlumca(Guid id)
        {
            Glumac? glumac = await _filmoviDbContext.Glumci.FindAsync(id);
            if (glumac is null) throw new KeyNotFoundException("Trazeni glumac nije pronadjen.");

            _filmoviDbContext.Glumci.Remove(glumac);
            await _filmoviDbContext.SaveChangesAsync();
        }

        public async Task<Glumac> PreuzmiGlumca(Guid id)
        {
            Glumac? glumac = await _filmoviDbContext.Glumci.FindAsync(id);
            if(glumac is null) throw new KeyNotFoundException("Trazeni glumac nije pronadjen.");
            return glumac;
        }
    }
}
