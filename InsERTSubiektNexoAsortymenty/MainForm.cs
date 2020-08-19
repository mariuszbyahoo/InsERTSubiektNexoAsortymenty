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
    }
}
