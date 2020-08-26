using InsERTSubiektNexoAsortymenty.Data.poco;
using InsERTSubiektNexoAsortymenty.Data.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektGTTowary.Srv
{
    public class SerwisZamowien : AbstrakcyjnySerwisSubiekta
    {
        public SerwisZamowien(InsERT.Subiekt aplikacja = null)
        {
            if (aplikacja == null)
                Aplikacja = PolaczZSubiektem();
            else
                Aplikacja = aplikacja;
        }
        public string ZapiszZamowienie(IEnumerable<Towar> towary, KlientInfo kontrahent)
        {
            var doc = Aplikacja.SuDokumentyManager.DodajZK();
            foreach (var towar in towary)
            {
                var poz = doc.Pozycje.Dodaj(towar.IdTowaru);
                poz.IloscJm = towar.Ilosc;
            }
            doc.KontrahentId = kontrahent.Id;
            doc.Zapisz();
            return doc.NumerPelny;
        }
    }
}
