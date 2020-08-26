using InsERTSubiektNexoAsortymenty.Data.poco;
using InsERTSubiektNexoAsortymenty.Data.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektGTTowary.Srv
{
    public class SerwisTowarow : AbstrakcyjnySerwisSubiekta
    {
        public SerwisTowarow(InsERT.Subiekt aplikacja = null)
        {
            if (aplikacja == null)
                Aplikacja = PolaczZSubiektem();
            else
                Aplikacja = aplikacja;
        }
        public BindingList<Towar> PodajWszystkieTowary()
        {
            var dane = Aplikacja.TowaryManager.OtworzKolekcje();


            var rezultat = new BindingList<Towar>();
            foreach (dynamic dana in dane)
            {
                if (dana.Aktywny)
                {
                    var danaDoTabeli = new Towar(dana.Identyfikator, dana.Nazwa, dana.CenaKartotekowa, dana.Symbol, dana.Opis);
                    rezultat.Add(danaDoTabeli);
                }
            }
            return rezultat;
        }
        public void ZmienOpis(string symbol, string nowyOpis)
        {
            var towar = Aplikacja.TowaryManager.WczytajTowar(symbol);
            towar.Opis = nowyOpis;
            towar.Zapisz();
        }
    }
}
