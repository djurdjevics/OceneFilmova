using OceneFilmova.Domen.Entieti;
using OceneFilmova.Domen.Funkcionalnosti;
using OceneFilmova.UI.Modeli;

namespace OceneFilmova.UI
{
    public partial class Tagovi : Form
    {
        private readonly TagServis _tagServis;
        private int _obelezeniTagId = default;
        private readonly NavigacioniServis _navigacioniServis;
        public Tagovi(TagServis tagServis, Filmovi filmovi, Glumci glumci, NavigacioniServis navigacioniServis)
        {
            _tagServis = tagServis;
            _navigacioniServis = navigacioniServis;
            InitializeComponent();
        }

        private void UcitajDataGrid(List<Tag> dobavljeniTagovi)
        {
            tagoviDataGrid.DataSource = dobavljeniTagovi;
        }

        private async void Tagovi_Load(object sender, EventArgs e)
        {
            UcitajDataGrid(await _tagServis.PreuzmiTagove());
        }

        private async void dodajBtn_Click(object sender, EventArgs e)
        {
            await _tagServis.DodajTag(new Tag(nazivTextBox.Text));
            MessageBox.Show("Uspesno dodat tag!");
            UcitajDataGrid(await _tagServis.PreuzmiTagove());
        }

        private async void obrisiBtn_Click(object sender, EventArgs e)
        {
            if (_obelezeniTagId == default)
            {
                MessageBox.Show("Nijedan tag nije obelezen!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati tag?", "Brisanje taga", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                await _tagServis.ObrisiTag(_obelezeniTagId);
            }
            catch(KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message);return;
            }
            catch(Exception)
            {
                MessageBox.Show("Brisanje taga nije uspelo!", "Brisanje taga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Uspesno obrisan tag!");
            _obelezeniTagId = default;
            UcitajDataGrid(await _tagServis.PreuzmiTagove());
        }

        private void tagoviDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var obelezeniRedovi = tagoviDataGrid.SelectedRows;
            if (obelezeniRedovi.Count == 0) return;
            _obelezeniTagId = (int)obelezeniRedovi[0].Cells[1].Value;
            PopuniTekstualnaPolja((Tag)tagoviDataGrid.SelectedRows[0].DataBoundItem);
        }

        private void PopuniTekstualnaPolja(Tag tag)
        {
            nazivTextBox.Text = tag.Naziv;
        }

        private void filmoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _navigacioniServis.Show<Filmovi>();
            Hide();
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _navigacioniServis.Show<Glumci>();
            Hide();
        }
    }
}
