using InsERT.Moria.Klienci;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektNexoAsortymenty.Data.Serwisy
{
    public class SerwisKlientow : BazowySerwisModeluDanych
    {
        private readonly Uchwyt _sfera;

        public SerwisKlientow()
        {
            _sfera = PolaczZeSfera();
        }

        public Podmiot[] PodajWszystkichKlientow()
        {
            var mgr = _sfera.PodajObiektTypu<IPodmioty>();

            return mgr.Dane.WszystkieFirmy().ToArray();
        }
    }
}
