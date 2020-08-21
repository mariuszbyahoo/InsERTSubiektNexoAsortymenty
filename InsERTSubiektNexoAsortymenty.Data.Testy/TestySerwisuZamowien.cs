using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using InsERT.Moria.Dokumenty.Logistyka;
using InsERT.Moria.ModelDanych;
using InsERTSubiektNexoAsortymenty.Data.Serwisy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsERTSubiektNexoAsortymenty.Data.Testy
{
    [TestClass]
    public class TestySerwisuZamowien
    {
        private readonly SerwisAsortymentow _srvAsortymentow;
        private readonly SerwisPodmiotow _srvKlientow;
        private readonly string symbolGlownegoMagazynu = "MAG";

        public TestySerwisuZamowien()
        {
            _srvAsortymentow = new SerwisAsortymentow();
            _srvKlientow = new SerwisPodmiotow();
        }

        [TestMethod]
        public void DodajZamowienie___Gdy_Wywolany_Poprawnie___Zwroci_Utworzone_Zamowienie()
        {
            // Przygotuj
            var wolumenZamowienia = 1m;
            var asortyment = _srvAsortymentow.PodajKonkretnyAsortyment(0);
            var podmioty = _srvKlientow.PodajWszystkiePodmioty();
            var klient = podmioty.FirstOrDefault();
            
            var wystawiajacy = podmioty.Where(f => f.Osoba != null && !(f.Id.Equals(klient.Id))).FirstOrDefault();
            var srv = new SerwisZamowien();
            var zamowioneAsortymenty = new Dictionary<Asortyment, decimal>();
            zamowioneAsortymenty.Add(asortyment, wolumenZamowienia);
            // Działaj
            var zam = srv.DodajZamowienie(klient, wystawiajacy.Osoba, symbolGlownegoMagazynu, zamowioneAsortymenty);

            // Sprawdź
            zam.Should().NotBeNull();
            zam.Should().BeAssignableTo<IZamowienieOdKlienta>();

            // Wyczyść 
            var czyUsunieto = zam.Usun();
            czyUsunieto.Should().BeTrue();
        }

        // Po wytłumaczenie komentarza tego testu patrz SerwisZamowien.cs
        //[TestMethod]
        //public void UsunZamowienie___Gdy_Wywolany_Poprawnie___Zwroci_True_I_Usunie_Podane_Zamowienie()
        //{
        //    // Przygotuj
        //    var wolumenZamowienia = 1m;
        //    var asortyment = _srvAsortymentow.PodajKonkretnyAsortyment(0);
        //    var podmioty = _srvKlientow.PodajWszystkiePodmioty();
        //    var klient = podmioty.FirstOrDefault();

        //    var wystawiajacy = podmioty.Where(f => f.Osoba != null && !(f.Id.Equals(klient.Id))).FirstOrDefault();
        //    var srv = new SerwisZamowien();
        //    var zamowioneAsortymenty = new Dictionary<Asortyment, decimal>();
        //    zamowioneAsortymenty.Add(asortyment, wolumenZamowienia);
        //    // Działaj
        //    var zam = srv.DodajZamowienie(klient, wystawiajacy.Osoba, symbolGlownegoMagazynu, zamowioneAsortymenty);
        //    zam.Should().NotBeNull();
        //    zam.Should().BeAssignableTo<IZamowienieOdKlienta>();
        //    var czyUsunieto = srv.UsunZamowienie(zam.Dane.Id);

        //    // Sprawdź
        //    czyUsunieto.Should().BeTrue();
        //}
    }
}
