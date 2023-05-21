using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Funkcionalnosti;
using OceneFilmova.UI.Modeli;
using System.Collections.ObjectModel;

namespace OceneFilmova.UI
{
    public partial class Filmovi : Form
    {
        private readonly FilmServis _filmServis;
        private readonly GlumacServis _glumacServis;
        private readonly TagServis _tagServis;
        private readonly NavigacioniServis _navigacioniServis;
        private Guid obelezeniFilmId = Guid.Empty;
        public Filmovi(FilmServis filmServis, GlumacServis glumacServis, TagServis tagServis, NavigacioniServis navigacioniServis)
        {
            _filmServis = filmServis;
            _glumacServis = glumacServis;
            _tagServis = tagServis;
            _navigacioniServis = navigacioniServis;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            UcitajDataGrid(await _filmServis.PreuzmiFilmove());
            await InicijalizujTagKontrole();
            await InicijalizujGlumciKontrole();
        }

        private async Task InicijalizujTagKontrole()
        {
            var dobavljeniTagovi = await _tagServis.PreuzmiTagove();
            tagoviListBox.DisplayMember = "Naziv";
            tagoviListBox.DataSource = dobavljeniTagovi.ToList();

            tagoviFilterComboBox.DisplayMember = "Naziv";
            tagoviFilterComboBox.DataSource = dobavljeniTagovi.ToList();
        }

        private async Task InicijalizujGlumciKontrole()
        {
            var dobavljeniGlumci = await _glumacServis.PreuzmiGlumce();
            glumciListBox.DisplayMember = "PunoIme";
            glumciListBox.DataSource = dobavljeniGlumci.ToList();

            glumciFilterComboBox.DisplayMember = "PunoIme";
            glumciFilterComboBox.DataSource = dobavljeniGlumci.ToList();
        }

        private void UcitajDataGrid(List<Film> dobavljeniFilmovi)
        {
            List<FilmDataGridModel> dataGridFilmovi = new();

            foreach (var film in dobavljeniFilmovi)
            {
                string glumci = string.Empty;
                foreach (Glumac glumac in film.Glumci)
                {
                    glumci += $"{glumac.Ime} {glumac.Prezime};";
                }


                string tagovi = string.Empty;
                foreach (Tag tag in film.Tagovi)
                {
                    tagovi += $"{tag.Naziv};";
                }
                FilmDataGridModel dataGridFilm = new(film.ID, film.Naslov, film.GodinaIzdanja, film.Ocena, film.Autor, glumci, tagovi, film.Deskripcija);
                dataGridFilmovi.Add(dataGridFilm);
            }
            filmoviDataGrid.DataSource = dataGridFilmovi;
        }


        private void PopuniTekstualnaPolja(FilmDataGridModel film)
        { 
            filmTextBox.Text = film.Naziv;
            autorTextBox.Text = film.Autor;
            deskripcijaRichTextBox.Text = film.Deskripcija;
            godinaTextBox.Text = film.GodinaIzdanja.ToString();
            ocenaComboBox.Text = film.Ocena.ToString();
        }

        private async void dodajBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Film filmZaDodati = new(Guid.NewGuid(),
                    filmTextBox.Text,
                    int.Parse(godinaTextBox.Text),
                    autorTextBox.Text,
                    deskripcijaRichTextBox.Text,
                    decimal.Parse((string)ocenaComboBox.SelectedItem),
                    glumciListBox.SelectedItems.OfType<Glumac>().ToList(),
                    tagoviListBox.SelectedItems.OfType<Tag>().ToList());
                await _filmServis.DodajFilm(filmZaDodati); // filmZaDodati - objekat tipa Film
            }
            catch(Exception)
            {
                MessageBox.Show("Dodavanje filma nije uspelo!", "Dodavanje filma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Film uspesno dodat!");
            UcitajDataGrid(await _filmServis.PreuzmiFilmove());
        }

        private async void izmeniBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Film filmZaIzmeniti = new(Guid.NewGuid(),
                    filmTextBox.Text,
                    int.Parse(godinaTextBox.Text),
                    autorTextBox.Text,
                    deskripcijaRichTextBox.Text,
                    decimal.Parse((string)ocenaComboBox.SelectedItem));
                await _filmServis.IzmeniFilm(obelezeniFilmId, filmZaIzmeniti);
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Izmena filma nije uspela", "Izmena filma" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Film uspesno izmenjen!");
            UcitajDataGrid(await _filmServis.PreuzmiFilmove());
        }

        private async void obrisiBtn_Click(object sender, EventArgs e)
        {
            if (obelezeniFilmId == Guid.Empty) {
                MessageBox.Show("Nijedan film nije obelezen!");
                return; 
            }

            DialogResult dialogResult =  MessageBox.Show("Da li ste sigurni da zelite obrisati film?", "Brisanje filma", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                await _filmServis.ObrisiFilm(obelezeniFilmId);
                MessageBox.Show("Uspesno obrisan film!");
                obelezeniFilmId = Guid.Empty;
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch(Exception ex) { 
                MessageBox.Show("Brisanje filma nije uspelo", "Brisanje filma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UcitajDataGrid(await _filmServis.PreuzmiFilmove());
        }

        private void filmoviDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var obelezeniRedovi = filmoviDataGrid.SelectedRows;

            if (obelezeniRedovi.Count == 0) return;

            obelezeniFilmId = (Guid)obelezeniRedovi[0].Cells[0].Value;

            PopuniTekstualnaPolja((FilmDataGridModel)filmoviDataGrid.SelectedRows[0].DataBoundItem);
        }

        private async void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _navigacioniServis.Show<Glumci>();
        }

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            Guid glumacFilter = glumciFilterComboBox.SelectedValue is null ? Guid.Empty : ((Glumac)glumciFilterComboBox.SelectedValue).ID;
            int tagFilter = tagoviFilterComboBox.SelectedValue is null ? default : ((Tag)tagoviFilterComboBox.SelectedValue).ID;
            List<Film> filmovi = await _filmServis.PreuzmiFilmove(glumacFilter, tagFilter);
            UcitajDataGrid(filmovi);
        }

        private async void resetFilterBtn_Click(object sender, EventArgs e)
        {
            List<Film> filmovi = await _filmServis.PreuzmiFilmove();
            UcitajDataGrid(filmovi);
        }

        private void tagoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _navigacioniServis.Show<Tagovi>();
            Hide();
        }
    }
}