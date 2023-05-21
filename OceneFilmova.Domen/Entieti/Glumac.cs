using OceneFilmova.Domen.Entieti.Bazni;

namespace OceneFilmova.Domen.Entieti
{
    public class Glumac : Entitet<Guid>
    {
        public Glumac(Guid id, string ime, string prezime, DateTime datumRodjenja) : base(id)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }

        private Glumac() { } //Entity Framework

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme => $"{Ime} {Prezime}";
        public List<Film> Filmovi { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }
}
