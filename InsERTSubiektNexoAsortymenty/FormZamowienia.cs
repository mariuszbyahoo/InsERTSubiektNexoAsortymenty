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

namespace InsERTSubiektNexoAsortymenty
{
    public partial class FormZamowienia : DevExpress.XtraEditors.XtraForm
    {
        private readonly Asortyment[] _asortymenty;
        public FormZamowienia(Asortyment[] asortymenty)
        {
            InitializeComponent();
            _asortymenty = asortymenty;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}