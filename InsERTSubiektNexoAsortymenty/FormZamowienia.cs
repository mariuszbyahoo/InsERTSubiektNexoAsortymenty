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

namespace InsERTSubiektNexoAsortymenty
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private readonly Asortyment[] _asortymenty;
        private Dictionary<int, int> wolumenZamowionychProduktow = new Dictionary<int, int>();

    public FormZamowienia(Asortyment[] asortymenty)
        {
            InitializeComponent();
            _asortymenty = asortymenty;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void tabelaWybranychProduktow_Load(object sender, EventArgs e)
        {
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
        }

        private void widokTabeliWybranychProduktow_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Ilosc")
            {
                for (int i = 0; i < this.widokTabeliWybranychProduktow.RowCount; i++)
                {
                    if(!wolumenZamowionychProduktow.ContainsKey(i))
                        wolumenZamowionychProduktow.Add(i, 1);
                }
                if (e.IsGetData)
                {
                    if (wolumenZamowionychProduktow.ContainsKey(e.ListSourceRowIndex))
                        e.Value = wolumenZamowionychProduktow[e.ListSourceRowIndex];
                }
                if (e.IsSetData && e.Value != null)
                {
                    wolumenZamowionychProduktow[e.ListSourceRowIndex] = (int)e.Value;
                }
            }
        }
    }
}