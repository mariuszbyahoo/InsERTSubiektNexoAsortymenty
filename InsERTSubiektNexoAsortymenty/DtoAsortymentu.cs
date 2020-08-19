using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using InsERT.Mox.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace InsERTSubiektNexoAsortymenty
{
    public class DtoAsortymentu : BazoweDto
    {
        public IList<Asortyment> PodajWszystkieAsortymenty()
        {
            using (var sfera = PolaczZeSfera())
            {
                var menedzerAsortymentow = sfera.PodajObiektTypu<IAsortymenty>();

                var dane = menedzerAsortymentow.Dane.Wszystkie();

                var rezultat = new BindingList<Asortyment>();
                foreach (var dana in dane)
                {
                    rezultat.Add(dana);
                }
                return rezultat;
            }
        }

        /// <summary>
        /// Zwraca wynik metody IAsortymenty.Znajdz(string Symbol)
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public IAsortyment PodajKonkretnyAsortyment(string symbol)
        {
            using (var sfera = PolaczZeSfera())
            {
                var mgr = sfera.PodajObiektTypu<IAsortymenty>();

                return mgr.Znajdz(symbol);
            }
        }

        /// <summary>
        /// Najpierw pobiera wszystkie Asortymenty, i potem zwraca element znaleziony pod przekazanym indexem
        /// </summary>
        /// <param name="indexWiersza">Index wiersza poszukiwanego asortymentu</param>
        /// <returns></returns>
        public Asortyment PodajKonkretnyAsortyment(int indexWiersza)
        {
            using (var sfera = PolaczZeSfera())
            {
                var mgr = sfera.PodajObiektTypu<IAsortymenty>();

                var tablicaAsortymentow = mgr.Dane.Wszystkie().ToArray();
                return tablicaAsortymentow[indexWiersza];
            }
        }

        public bool ZmienOpis(string symbol, string nowyOpis)
        {
            using (var sfera = PolaczZeSfera())
            {
                IAsortymenty mgr = sfera.PodajObiektTypu<IAsortymenty>();
                using (var e = mgr.Znajdz(symbol))
                {
                    e.Dane.Opis = nowyOpis;

                    return e.Zapisz();
                }
            }

        }
    }
}
