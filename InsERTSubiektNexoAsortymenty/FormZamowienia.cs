using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InsERT.Moria.ModelDanych;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using InsERTSubiektNexoAsortymenty.Data.Poco;
using InsERTSubiektNexoAsortymenty.Data.Serwisy.Nexo;

namespace InsERTSubiektNexoAsortymenty
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private Podmiot[] _klienci;
        private readonly Asortyment[] _asortymenty;
        private readonly SerwisPodmiotow _serwisPodmiotow;
        private readonly SerwisZamowien _serwisZamowien;
        private readonly Dictionary<int, int> _wolumenZamowionychProduktow;

    public FormZamowienia(Asortyment[] asortymenty)
        {
            InitializeComponent();
            _asortymenty = asortymenty;
            _serwisPodmiotow = new SerwisPodmiotow();
            _serwisZamowien = new SerwisZamowien();
            _wolumenZamowionychProduktow = new Dictionary<int, int>();
        }

        private void tabelaWybranychProduktow_Load(object sender, EventArgs e)
        {
            // Zapełnienie kolumn
            this.tabelaWybranychProduktow.DataSource = _asortymenty;
            for (int i = 0; i < this.widokTabeliWybranychProduktow.Columns.Count; i++)
            {
                if (this.widokTabeliWybranychProduktow.Columns[i].FieldName.Equals("Nazwa") ||
                    this.widokTabeliWybranychProduktow.Columns[i].FieldName.Equals("CenaEwidencyjna"))
                {
                    this.widokTabeliWybranychProduktow.Columns[i].Visible = true;
                }
                else
                {
                    this.widokTabeliWybranychProduktow.Columns[i].Visible = false;
                }
            }
            var kolumnaIlosc = new KolumnaIlosc(widokTabeliWybranychProduktow);

            _klienci = _serwisPodmiotow.PodajWszystkieFirmy();

            // Zapełnienie pola wyboru
            ComboBoxItemCollection zbiorKlientowDoWyboru = this.poleWyboruKlienta.Properties.Items;
            zbiorKlientowDoWyboru.BeginUpdate();
            for (int i = 0; i < _klienci.Length; i++)
            {
                zbiorKlientowDoWyboru.Add(new KlientInfo(_klienci[i]));
            }
            zbiorKlientowDoWyboru.EndUpdate();
        }

        private void widokTabeliWybranychProduktow_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Ilosc")
            {
                for (int i = 0; i < this.widokTabeliWybranychProduktow.RowCount; i++)
                {
                    if(!_wolumenZamowionychProduktow.ContainsKey(i))
                        _wolumenZamowionychProduktow.Add(i, 1);
                }
                if (e.IsGetData)
                {
                    if (_wolumenZamowionychProduktow.ContainsKey(e.ListSourceRowIndex))
                        e.Value = _wolumenZamowionychProduktow[e.ListSourceRowIndex];
                }
                if (e.IsSetData && e.Value != null)
                {
                    _wolumenZamowionychProduktow[e.ListSourceRowIndex] = (int)e.Value;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if(this.poleWyboruKlienta.SelectedIndex > -1)
            {
                var magazynGlowny = "MAG"; // Nie wskazano potrzeby wybrania magazynu
                var zamawiajacy = _klienci[this.poleWyboruKlienta.SelectedIndex];
                var asortymentyZWolumenem = new Dictionary<Asortyment, decimal>();
                for (int i = 0; i < _asortymenty.Length; i++)
                {
                    asortymentyZWolumenem.Add(_asortymenty[i], _wolumenZamowionychProduktow[i]);
                }
                // Poniższe do zmiany, nie wskazano w wymaganiach póki co jak załatwić kwestię osoby wystawiającej dokument.
                var wystawiajacy = _serwisPodmiotow.PodajWszystkiePodmioty().Where(p => p.Osoba != null).FirstOrDefault().Osoba;

                var procesowaneZamowienie = _serwisZamowien.DodajZamowienie(
                    zamawiajacy, wystawiajacy, magazynGlowny, 
                    asortymentyZWolumenem);

                var dialog = new FormPotwierdzeniaZamowienia(
                    asortymentyZWolumenem, 
                    procesowaneZamowienie.Dane.NumerWewnetrzny.PelnaSygnatura);
                dialog.ShowDialog();
                this.Close();
            }
            else
            {
                var dialog = new FormBlednegoZamawiajacego();
                dialog.ShowDialog();
            }
        }
    }
}