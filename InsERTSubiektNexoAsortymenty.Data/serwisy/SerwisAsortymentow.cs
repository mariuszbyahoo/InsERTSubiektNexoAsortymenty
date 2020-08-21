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

namespace InsERTSubiektNexoAsortymenty.Data.Serwisy
{
    public class SerwisAsortymentow : BazowySerwisModeluDanych
    {
        private readonly Uchwyt _sfera;

        public SerwisAsortymentow()
        {
            _sfera = this.PolaczZeSfera();
        }

        public IList<Asortyment> PodajWszystkieAsortymenty()
        {

            var menedzerAsortymentow = _sfera.PodajObiektTypu<IAsortymenty>();

            var dane = menedzerAsortymentow.Dane.Wszystkie();

            var rezultat = new BindingList<Asortyment>();
            foreach (var dana in dane)
            {
                rezultat.Add(dana);
            }
            return rezultat;
        }

        /// <summary>
        /// Zwraca wynik metody IAsortymenty.Znajdz(string Symbol)
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public IAsortyment PodajKonkretnyAsortyment(string symbol)
        {
            var mgr = _sfera.PodajObiektTypu<IAsortymenty>();

            return mgr.Znajdz(symbol);
        }

        /// <summary>
        /// Najpierw pobiera wszystkie Asortymenty, i potem zwraca element znaleziony pod przekazanym indexem
        /// </summary>
        /// <param name="indexWiersza">Index wiersza poszukiwanego asortymentu</param>
        /// <returns></returns>
        public Asortyment PodajKonkretnyAsortyment(int indexWiersza)
        {

            var mgr = _sfera.PodajObiektTypu<IAsortymenty>();

            var tablicaAsortymentow = mgr.Dane.Wszystkie().ToArray();
            return tablicaAsortymentow[indexWiersza];
        }

        public bool ZmienOpis(string symbol, string nowyOpis)
        {

            IAsortymenty mgr = _sfera.PodajObiektTypu<IAsortymenty>();
            using (var e = mgr.Znajdz(symbol))
            {
                e.Dane.Opis = nowyOpis;

                return e.Zapisz();
            }
        }
    }
}
