using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InsERTSubiektNexoAsortymenty.Data.poco;
using DevExpress.XtraEditors.Controls;
using InsERTSubiektNexoAsortymenty.Data.Poco;

namespace InsERTSubiektGTTowary
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEnumerable<KlientInfo> _kontrahenci;
        private readonly IEnumerable<Towar> _towary;
        private readonly Dictionary<int, int> _wolumenZamowionychProduktow;
        private readonly SerwisSubiekta _dto;
        public FormZamowienia(SerwisSubiekta serwis, Towar[] towary)
        {
            InitializeComponent();
            _dto = serwis;
            _kontrahenci = _dto.PodajKontrahentow();
            _towary = towary;
            _wolumenZamowionychProduktow = new Dictionary<int, int>();
            this.gridControl1.DataSource = towary;
        }

        private void FormZamowienia_Load(object sender, EventArgs e)
        {
            // Zapełnienie pola wyboru
            ComboBoxItemCollection zbiorKlientowDoWyboru = this.comboBoxEdit1.Properties.Items;
            zbiorKlientowDoWyboru.BeginUpdate();
            foreach (var k in _kontrahenci)
            {
                zbiorKlientowDoWyboru.Add(k);
            }
            zbiorKlientowDoWyboru.EndUpdate();

            new KolumnaIlosc(this.gridView1);
        }

        private void przyciskOk_Click(object sender, EventArgs e)
        {
            if (this.comboBoxEdit1.SelectedIndex > -1)
            {
                var wybranyKontrahent = (KlientInfo)this.comboBoxEdit1.Properties.Items[this.comboBoxEdit1.SelectedIndex];
                _dto.ZapiszZamowienie(_towary, wybranyKontrahent);
            }
            else
            {
                var dialog = new FormBlednegoZamawiajacego();
                dialog.Show(this);
            }
        }

        private void przyciskAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Ilosc")
            {
                for (int i = 0; i < this.gridView1.RowCount; i++)
                {
                    if (!_wolumenZamowionychProduktow.ContainsKey(i))
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
    }
}
