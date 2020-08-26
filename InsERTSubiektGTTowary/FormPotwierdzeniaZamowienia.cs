using DevExpress.XtraEditors;
using InsERTSubiektNexoAsortymenty.Data.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsERTSubiektGTTowary
{
    public partial class FormPotwierdzeniaZamowienia : XtraForm
    {
        private readonly string _numerZamowienia;
        private readonly List<string> _zamowioneTowary;
        public FormPotwierdzeniaZamowienia(Towar[] towary, string numerZamowienia)
        {
            _zamowioneTowary = new List<string>();
            foreach (var towar in towary)
            {
                _zamowioneTowary.Add($"{towar.Nazwa}, w ilości: {towar.Ilosc}");
            }
            _numerZamowienia = numerZamowienia;
            InitializeComponent();
        }

        private void FormPotwierdzeniaZamowienia_Load(object sender, EventArgs e)
        {
            this.listaZamowionychProduktow.DataSource = _zamowioneTowary;
            this.numerUtworzonegoZamowienia.Text += _numerZamowienia;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
