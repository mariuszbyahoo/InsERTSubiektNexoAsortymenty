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

            for (int i = 0; i < this.tabelaWszystkichTowarow.Columns.Count; i++)
            {
                if (this.tabelaWszystkichTowarow.Columns[i].FieldName.Equals("IdTowaru"))
                {
                    this.tabelaWszystkichTowarow.Columns[i].Visible = false;
                }
            }
        }

        private void tabelaTowarow_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = this.tabelaTowarow.FocusedView as GridView;
            var wybranyTowar = (Towar)gridView.GetRow(gridView.FocusedRowHandle);

            _dto.ZmienOpis(wybranyTowar.Symbol, wybranyTowar.Opis);
        }

        private void przyciskZamowienia_Click(object sender, EventArgs e)
        {
            var wybraneWiersze = this.tabelaWszystkichTowarow.GetSelectedRows();

            var wybraneEncje = new Towar[wybraneWiersze.Length];
            for (int i = 0; i < wybraneWiersze.Length; i++)
            {
                var encja = this.tabelaWszystkichTowarow.GetRow(wybraneWiersze[i]);
                wybraneEncje[i] = (Towar)encja;
            }
            // I tutaj wywołaj okno dialogowe jako callback
            var dialog = new FormZamowienia(_dto, wybraneEncje);
            dialog.ShowDialog();
        }
    }
}
