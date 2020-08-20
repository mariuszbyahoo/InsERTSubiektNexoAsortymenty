using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsERTSubiektNexoAsortymenty
{
    public partial class KolumnaIlosc : XtraUserControl
    {
        public KolumnaIlosc(GridView gridView)
        {
            // Creating an unbound column that supports editing
            GridColumn unboundColumn = gridView.Columns.AddField("Ilosc");
            unboundColumn.UnboundType = UnboundColumnType.Integer;
            unboundColumn.Visible = true;
        }
        void OnDisposing()
        {
            (this.Controls[0] as GridControl).Dispose();
        }
    }
}
