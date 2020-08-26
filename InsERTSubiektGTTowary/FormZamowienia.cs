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

namespace InsERTSubiektGTTowary
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        public FormZamowienia(Towar[] towary)
        {
            InitializeComponent();
            this.gridControl1.DataSource = towary;
        }
    }
}
