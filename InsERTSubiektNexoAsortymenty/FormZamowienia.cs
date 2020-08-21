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
using InsERTSubiektNexoAsortymenty.Data;
using InsERTSubiektNexoAsortymenty.Data.Serwisy;
using InsERTSubiektNexoAsortymenty.Data.Poco;

namespace InsERTSubiektNexoAsortymenty
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private readonly Asortyment[] _asortymenty;
        private readonly SerwisKlientow _serwisKlientow;
        private readonly Dictionary<int, int> _wolumenZamowionychProduktow;

    public FormZamowienia(Asortyment[] asortymenty)
        {
            InitializeComponent();
            _asortymenty = asortymenty;
            _serwisKlientow = new SerwisKlientow();
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

            var klienci = _serwisKlientow.PodajWszystkichKlientow();

            // Zapełnienie pola wyboru
            ComboBoxItemCollection zbiorKlientowDoWyboru = this.poleWyboruKlienta.Properties.Items;
            zbiorKlientowDoWyboru.BeginUpdate();
            for (int i = 0; i < klienci.Length; i++)
            {
                zbiorKlientowDoWyboru.Add(new KlientInfo(klienci[i]));
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
                // Dodaj zamówienie poprzez API
            }
            else
            {
                // Wyświetl komunikat o niedokonanym wyborze Klienta.
            }
        }
    }
}