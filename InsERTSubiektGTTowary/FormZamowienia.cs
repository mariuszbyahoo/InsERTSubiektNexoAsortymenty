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
        public FormZamowienia(Towar[] towary, IEnumerable<KlientInfo> kontrahenci)
        {
            InitializeComponent();
            _kontrahenci = kontrahenci;
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
    }
}
