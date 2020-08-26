using InsERTSubiektGTTowary.Srv;
using InsERTSubiektNexoAsortymenty.Data.poco;
using InsERTSubiektNexoAsortymenty.Data.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektGTTowary
{
    public abstract class AbstrakcyjnySerwisSubiekta 
    {
        public InsERT.Subiekt Aplikacja { get; set; }

        public InsERT.Subiekt PolaczZSubiektem()
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
