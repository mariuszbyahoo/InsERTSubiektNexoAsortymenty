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
using InsERTSubiektGTTowary.Srv;

namespace InsERTSubiektGTTowary
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEnumerable<KlientInfo> _kontrahenci;
        private readonly Dictionary<int, int> _wolumenZamowionychProduktow;
        private readonly SerwisKontrahentow _serwisKontrahentow;
        private readonly SerwisZamowien _serwisZamowien;
        public FormZamowienia(AbstrakcyjnySerwisSubiekta serwis, Towar[] towary)
        {
            InitializeComponent();
            _serwisKontrahentow = new SerwisKontrahentow(serwis.Aplikacja);
            _serwisZamowien = new SerwisZamowien(serwis.Aplikacja);
            _kontrahenci = _serwisKontrahentow.PodajKontrahentow();
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
        }

        private void przyciskOk_Click(object sender, EventArgs e)
        {
            if (this.comboBoxEdit1.SelectedIndex > -1)
            {
                var towaryDoZamowienia = new Towar[this.gridView1.RowCount];
                for (int i = 0; i < this.gridView1.RowCount; i++)
                {
                    towaryDoZamowienia[i] = (Towar)this.gridView1.GetRow(i);
                }
                var wybranyKontrahent = (KlientInfo)this.comboBoxEdit1.Properties.Items[this.comboBoxEdit1.SelectedIndex];
                var numer = _serwisZamowien.ZapiszZamowienie(towaryDoZamowienia, wybranyKontrahent);

                var dialog = new FormPotwierdzeniaZamowienia(towaryDoZamowienia, numer);
                dialog.ShowDialog();
                this.Close();
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
    }
}
