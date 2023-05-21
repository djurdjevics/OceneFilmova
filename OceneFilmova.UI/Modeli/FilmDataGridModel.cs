namespace OceneFilmova.UI.Modeli
{
    internal class FilmDataGridModel
    {
        public FilmDataGridModel(Guid id,string naziv, int godinaIzdanja, decimal ocena, string autor, string glumci, string tagovi, string deskripcija)
        {
            Id = id;
            Naziv = naziv;
            GodinaIzdanja = godinaIzdanja;
            Ocena = ocena;
            Autor = autor;
            Glumci = glumci;
            Tagovi = tagovi;
            Deskripcija = deskripcija;
        }

        public Guid Id { get; set; }
        public string Naziv { get; set; }
        public int GodinaIzdanja { get; set; }
        public decimal Ocena { get; set; }
        public string Autor { get; set; }
        public string Glumci { get; set; }
        public string Tagovi { get; set; }

        public string Deskripcija { get; set; }
    }
}
