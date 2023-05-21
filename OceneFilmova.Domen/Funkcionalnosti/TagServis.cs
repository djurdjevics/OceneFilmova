using Microsoft.EntityFrameworkCore;
using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Interfejsi;
using System.Diagnostics.Contracts;

namespace OceneFilmova.Domen.Funkcionalnosti
{
    public class TagServis
    {
        private readonly IFilmoviDbContext _filmoviDbContext;

        public TagServis(IFilmoviDbContext filmoviDbContext)
        {
            _filmoviDbContext = filmoviDbContext;
        }

        public async Task<List<Tag>> PreuzmiTagove()
        {
            return await _filmoviDbContext.Tagovi.ToListAsync();
        }

        public async Task DodajTag(Tag tagZaDodati)
        {
            _filmoviDbContext.Tagovi.Add(tagZaDodati);
            await _filmoviDbContext.SaveChangesAsync();
        }

        public async Task ObrisiTag(int id)
        {
            Tag? tagZaObrisati = await _filmoviDbContext.Tagovi.FindAsync(id);
            if (tagZaObrisati is null) throw new KeyNotFoundException("Trazeni tag ne postoji!");
            _filmoviDbContext.Tagovi.Remove(tagZaObrisati);
            await _filmoviDbContext.SaveChangesAsync();
        }
    }
}
