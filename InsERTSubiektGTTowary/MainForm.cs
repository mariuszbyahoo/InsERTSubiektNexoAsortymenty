using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using InsERTSubiektNexoAsortymenty.Data.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InsERTSubiektGTTowary
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private readonly SerwisSubiekta _dto;

        public MainView()
        {
            _dto = new SerwisSubiekta();
            InitializeComponent();
        }



        private void MainView_Load(object sender, EventArgs e)
        {
            this.tabelaTowarow.DataSource = _dto.PodajWszystkieTowary();

            for (int i = 0; i < this.gridView1.Columns.Count; i++)
            {
                if (this.gridView1.Columns[i].FieldName.Equals("IdTowaru"))
                {
                    this.gridView1.Columns[i].Visible = false;
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = this.tabelaTowarow.FocusedView as GridView;
            var wybranyTowar = (Towar)gridView.GetRow(gridView.FocusedRowHandle);

            _dto.ZmienOpis(wybranyTowar.Symbol, wybranyTowar.Opis);
        }
    }
}
