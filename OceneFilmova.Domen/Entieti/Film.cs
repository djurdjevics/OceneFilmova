using OceneFilmova.Domen.Entieti.Bazni;

namespace OceneFilmova.Domen.Entieti
{
    public class Film : Entitet<Guid>
    {
        public Film(Guid id,string naslov, int godinaIzdanja, string autor, string deskripcija, decimal ocena) : base(id)
        {
            Naslov = naslov;
            GodinaIzdanja = godinaIzdanja;
            Autor = autor;
            Deskripcija = deskripcija;
            Ocena = ocena;
        }

        public Film(Guid id,string naslov, int godinaIzdanja, string autor, string deskripcija, decimal ocena, List<Glumac> glumci, List<Tag> tagovi) : base(id)
        {
            Naslov = naslov;
            GodinaIzdanja = godinaIzdanja;
            Autor = autor;
            Deskripcija = deskripcija;
            Ocena = ocena;
            Glumci = glumci;
            Tagovi = tagovi;
        }

        private Film() { } //Entity Framework

        public string Naslov { get; set; }
        public int GodinaIzdanja { get; set; }
        public string Autor { get; set; }
        public string Deskripcija { get; set; }
        public decimal Ocena { get; set; }
        public List<Glumac> Glumci { get; set; }
        public List<Tag> Tagovi { get; set; }
    }
}
