using Microsoft.Extensions.DependencyInjection;
using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Funkcionalnosti;
using OceneFilmova.UI.Modeli;

namespace OceneFilmova.UI
{
    public partial class Glumci : Form
    {
        private readonly GlumacServis _glumacServis;
        private Guid _obelezeniGlumacId;
        private readonly NavigacioniServis _navigacioniServis;
        public Glumci(GlumacServis glumacServis, NavigacioniServis navigacioniServis)
        {
            _glumacServis = glumacServis;
            _navigacioniServis = navigacioniServis;
            InitializeComponent();
        }

        private async void dodajBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Glumac glumacZaDodati = new(Guid.NewGuid(), imeTextBox.Text, prezimeTextBox.Text, DateTime.Parse(datumRodjenjaPicker.Text));
                await _glumacServis.DodajGlumca(glumacZaDodati);
            }
            catch (Exception)
            {
                MessageBox.Show("Dodavanje glumca nije uspelo!", "Dodavanje glumca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UcitajDataGrid(await _glumacServis.PreuzmiGlumce());
        }


        private async void obrisiBtn_Click(object sender, EventArgs e)
        {
            if (_obelezeniGlumacId == Guid.Empty)
            {
                MessageBox.Show("Nijedan film nije obelezen!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati glumca?", "Brisanje glumca", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            await _glumacServis.ObrisiGlumca(_obelezeniGlumacId);
            MessageBox.Show("Uspesno obrisan film!");
            _obelezeniGlumacId = Guid.Empty;
            UcitajDataGrid(await _glumacServis.PreuzmiGlumce());
        }

        private void UcitajDataGrid(List<Glumac> dobavljeniGlumci)
        {
            glumciDataGrid.DataSource = dobavljeniGlumci;
        }

        private async void Glumci_Load(object sender, EventArgs e)
        {
            UcitajDataGrid(await _glumacServis.PreuzmiGlumce());
        }

        private void glumciDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var obelezeniRedovi = glumciDataGrid.SelectedRows;
            if (obelezeniRedovi.Count == 0) return;
            _obelezeniGlumacId = (Guid)obelezeniRedovi[0].Cells[4].Value;
            PopuniTekstualnaPolja((Glumac)glumciDataGrid.SelectedRows[0].DataBoundItem);
        }

        private void PopuniTekstualnaPolja(Glumac glumac)
        {
            imeTextBox.Text = glumac.Ime;
            prezimeTextBox.Text = glumac.Prezime;
            datumRodjenjaPicker.Value = glumac.DatumRodjenja;
        }

        private void filmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _navigacioniServis.Show<Filmovi>();
            Hide();
        }

        private void tagoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _navigacioniServis.Show<Tagovi>();
            Hide();
        }
    }
}
