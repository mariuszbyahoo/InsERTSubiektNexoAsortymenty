using DevExpress.XtraGrid.Views.Base;
using InsERT.Moria.Asortymenty;
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
    }
}
