using Microsoft.EntityFrameworkCore;
using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Interfejsi;

namespace OceneFilmova.Domen.Funkcionalnosti
{
    public class FilmServis
    {
        private readonly IFilmoviDbContext _filmoviDbContext;
        public FilmServis(IFilmoviDbContext filmoviDbContext)
        {
            _filmoviDbContext = filmoviDbContext;
        }

        public async Task<List<Film>> PreuzmiFilmove(Guid glumacFilter = default, int tagFilter = default) {
            IQueryable<Film> filmovi = _filmoviDbContext.Filmovi
                                                  .Include(film => film.Tagovi)
                                                  .Include(film => film.Glumci);

            if (glumacFilter != Guid.Empty) filmovi = filmovi.Where(film => film.Glumci.Any(glumac => glumac.ID == glumacFilter));
            if (tagFilter != default) filmovi = filmovi.Where(film => film.Tagovi.Any(tag => tag.ID == tagFilter));



            return await filmovi.ToListAsync();
        }

        public async Task DodajFilm(Film filmZaDodati) {
            _filmoviDbContext.Filmovi.Add(filmZaDodati);
            await _filmoviDbContext.SaveChangesAsync();
        }

        public async Task IzmeniFilm(Guid id, Film izmenjeniFilm)
        {
            Film? filmZaPromeniti = await _filmoviDbContext.Filmovi.FindAsync(id);
            if (filmZaPromeniti is null) throw new KeyNotFoundException("Traženi film nije pronađen.");
            filmZaPromeniti.Naslov = izmenjeniFilm.Naslov;
            filmZaPromeniti.Ocena = izmenjeniFilm.Ocena;
            filmZaPromeniti.Autor = izmenjeniFilm.Autor;
            filmZaPromeniti.Deskripcija = izmenjeniFilm.Deskripcija;
            await _filmoviDbContext.SaveChangesAsync();
        }

        public async Task ObrisiFilm(Guid id) {
            Film? filmZaObrisati = await _filmoviDbContext.Filmovi.FindAsync(id);
            if (filmZaObrisati is null) throw new KeyNotFoundException("Traženi film nije pronađen.");
            _filmoviDbContext.Filmovi.Remove(filmZaObrisati);
            await _filmoviDbContext.SaveChangesAsync();
        }
    }
}
