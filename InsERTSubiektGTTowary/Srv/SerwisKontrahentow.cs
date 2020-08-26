using InsERTSubiektNexoAsortymenty.Data.Poco;
using System.ComponentModel;

namespace InsERTSubiektGTTowary.Srv
{
    public class SerwisKontrahentow : AbstrakcyjnySerwisSubiekta
    {
        public SerwisKontrahentow(InsERT.Subiekt aplikacja = null)
        {
            if (aplikacja == null)
                Aplikacja = PolaczZSubiektem();
            else
                Aplikacja = aplikacja;
        }
        public BindingList<KlientInfo> PodajKontrahentow()
        {
            var kol = Aplikacja.KontrahenciManager.OtworzKolekcje();
            var rezultat = new BindingList<KlientInfo>();
            foreach (dynamic k in kol)
            {
                if (k.Aktywny)
                {
                    var danaDoTabeli = new KlientInfo(k.Nazwa, k.NIP, k.Identyfikator);
                    rezultat.Add(danaDoTabeli);
                }
            }
            return rezultat;
        }
    }
}
