using InsERTSubiektNexoAsortymenty.Data.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektGTTowary
{
    public class SerwisSubiekta
    {
        InsERT.Subiekt _aplikacja;
        public SerwisSubiekta()
        {
            _aplikacja = PolaczZSubiektem();
        }

        public BindingList<Towar> PodajWszystkieTowary()
        {
            var dane = _aplikacja.TowaryManager.OtworzKolekcje();


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

        private InsERT.Subiekt PolaczZSubiektem()
        {
            var gt = new InsERT.GT();
            InsERT.Subiekt sgt;

            gt.Produkt = InsERT.ProduktEnum.gtaProduktSubiekt;
            gt.Serwer = "(local)\\InsertGT";
            gt.Baza = "NoweDemo";
            gt.Autentykacja = InsERT.AutentykacjaEnum.gtaAutentykacjaMieszana;
            gt.Uzytkownik = "";
            gt.UzytkownikHaslo = "";
            gt.Operator = "Szef";
            gt.OperatorHaslo = "";

            sgt = (InsERT.Subiekt)gt.Uruchom((int)InsERT.UruchomDopasujEnum.gtaUruchomDopasuj, (int)InsERT.UruchomEnum.gtaUruchomWTle);
            sgt.Okno.Widoczne = false;
            return sgt;
        }
    }
}
