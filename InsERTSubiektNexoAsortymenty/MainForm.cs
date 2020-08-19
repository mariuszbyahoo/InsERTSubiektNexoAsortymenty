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
        private readonly DtoAsortymentu _dto;

        public MainForm()
        {
            _dto = new DtoAsortymentu();
            InitializeComponent();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            /* Tu użyj DtoAsortymentu do wysłania poprzez InsertAPI żądania zmiany wiersza, gdzie nową wartością będzie 
             ta pochodząca z CellValueChangedEventArgs */
        }
    }
}
