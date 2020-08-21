using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektNexoAsortymenty.Data.Serwisy
{
    /// <summary>
    /// Póki co pozostawiłem go takiego jak jest, nieużywany jako że ustaliliśmy żeby nie pokazywać symboli walut.
    /// </summary>
    public class SerwisWalut : BazowySerwisModeluDanych
    {
        public IList<Waluta> PodajWaluty()
        {
            using (var uchwyt = PolaczZeSfera())
            {
                var mgr = uchwyt.PodajObiektTypu<InsERT.Moria.Waluty.IWaluty>();
                var dane = mgr.Dane.Wszystkie();
                var rezultat = new List<Waluta>();
                foreach (var dana in dane)
                {
                    rezultat.Add(dana);
                }
                return rezultat;
            }
        }
    }
}
