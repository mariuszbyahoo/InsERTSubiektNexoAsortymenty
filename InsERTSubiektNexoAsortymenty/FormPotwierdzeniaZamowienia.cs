using DevExpress.XtraEditors;
using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsERTSubiektNexoAsortymenty
{
    public partial class FormPotwierdzeniaZamowienia : XtraForm
    {
        private readonly string _numerZamowienia;
        private readonly List<string> _zamowioneAsortymenty;
        public FormPotwierdzeniaZamowienia(Dictionary<Asortyment, decimal> asortymentyZWolumenem, string numerZamowienia)
        {
            _zamowioneAsortymenty = new List<string>();
            foreach (var asortymentZWolumenem in asortymentyZWolumenem)
            {
                _zamowioneAsortymenty.Add($"{asortymentZWolumenem.Key.Nazwa}, w ilości: {asortymentZWolumenem.Value}");
            }
            _numerZamowienia = numerZamowienia;
            InitializeComponent();
        }

        private void FormPotwierdzeniaZamowienia_Load(object sender, EventArgs e)
        {
            this.listaZamowionychProduktow.DataSource = _zamowioneAsortymenty;
            this.numerUtworzonegoZamowienia.Text += _numerZamowienia;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
