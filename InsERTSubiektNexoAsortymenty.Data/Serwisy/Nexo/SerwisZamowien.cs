﻿using InsERT.Moria.Dokumenty.Logistyka;
using InsERT.Moria.Klienci;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.ModelOrganizacyjny;
using InsERT.Moria.Sfera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Data.Serwisy.Nexo
{
    public class SerwisZamowien : BazowySerwisModeluDanych
    {
        private readonly Uchwyt _uchwyt;

        public SerwisZamowien()
        {
            _uchwyt = PolaczZeSfera();
        }

        public IZamowienieOdKlienta DodajZamowienie(
            Podmiot zamawiajacy, 
            Osoba wystawiajacy,
            string symbolMagazynu, 
            Dictionary<Asortyment, decimal> zamowioneProdukty)
        {
            if (symbolMagazynu.Length > 3)
                throw new ArgumentOutOfRangeException("Symbol powinien zawierać trzy znaki!");

            var konfig = _uchwyt.PodajObiektTypu<IKonfiguracje>().DaneDomyslne.ZamowienieOdKlienta;
            var mag = _uchwyt.PodajObiektTypu<IMagazyny>().Dane.Wszystkie().Where(m => m.Symbol.Equals(symbolMagazynu)).FirstOrDefault();
            var mgrZamowien = _uchwyt.PodajObiektTypu<IZamowieniaOdKlientow>();
            var pozycje = new List<PozycjaDokumentu>();

            if (mag == null)
                throw new ArgumentException("Nie znaleziono podanego magazynu");

            var zk = mgrZamowien.Utworz(konfig);

            zk.Dane.Magazyn = mag;
            zk.Dane.Podmiot = zamawiajacy;

            foreach (var produkt in zamowioneProdukty)
            {
                pozycje.Add(zk.Pozycje.Dodaj(produkt.Key, produkt.Value, produkt.Key.JednostkaSprzedazy));
            }

            zk.Dane.WystawilaOsoba = wystawiajacy;

            if (zk.Zapisz())
                return zk;
            else
                throw new InvalidOperationException("Zapis zamówienia się nie powiódł");
        }

        //public bool UsunZamowienie(int IdZamowieniaDoWykasowania)
        //{
        //    var mgrZamowien = _uchwyt.PodajObiektTypu<IZamowieniaOdKlientow>();

        // Ta metoda wyrzuci mi wyjątek, a jako powód pokazuje że proprty "key" jest nullem, co jest co najmniej dziwne 
        // jako że przyporządkowuję mu ID, wolę zająć się wtenczas wymaganiami do spełnienia w ticket'ie a te sprawę
        // zostawię sobie na później

        //    var szukane = new DokumentZK() { Id = IdZamowieniaDoWykasowania };
        //    var zamowienie = mgrZamowien.Znajdz(szukane);
        //    return zamowienie.Usun();
        //}
    }
}
