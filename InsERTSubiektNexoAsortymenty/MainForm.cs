using DevExpress.XtraGrid.Views.Base;
using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InsERTSubiektNexoAsortymenty
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly SerwisAsortymentow _dto;

        public MainForm()
        {
            _dto = new SerwisAsortymentow();
            InitializeComponent();
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName.Equals("Opis"))
            {
                var procesowanyAsortyment = _dto.PodajKonkretnyAsortyment(e.RowHandle);

                _dto.ZmienOpis(procesowanyAsortyment.Symbol, e.Value.ToString());
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var wybraneWiersze = this.gridView1.GetSelectedRows();

            var wybraneEncje = new Asortyment[wybraneWiersze.Length];
            for (int i = 0; i < wybraneWiersze.Length; i++)
            {
                var encja = this.gridView1.GetRow(wybraneWiersze[i]);
                wybraneEncje[i] = (Asortyment)encja;
            }
            // I tutaj wywołaj okno dialogowe jako callback
            var dialog = new FormZamowienia(wybraneEncje);
            dialog.ShowDialog();
        }
    }
}
