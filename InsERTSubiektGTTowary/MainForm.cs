using DevExpress.XtraGrid.Views.Base;
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

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName.Equals("Opis"))
            //{
            //    var procesowanyAsortyment = _dto.PodajKonkretnyAsortyment(e.RowHandle);

            //    _dto.ZmienOpis(procesowanyAsortyment.Symbol, e.Value.ToString());
            //}
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
    }
}
