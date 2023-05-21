using OceneFilmova.Domen.Entieti.Bazni;

namespace OceneFilmova.Domen.Entieti
{
    public class Tag : Entitet<int>
    {
        public Tag(string naziv)
        {
            Naziv = naziv;
        }

        private Tag() { } //Entity Framework

        public string Naziv { get; set; }
        public List<Film> Filmovi { get; set; }
    }
}
