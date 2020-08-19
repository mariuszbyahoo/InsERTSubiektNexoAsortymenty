using System;
using System.Collections.Generic;
using System.ComponentModel;
using FluentAssertions;
using InsERT.Moria.ModelDanych;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsERTSubiektNexoAsortymenty.Data.Testy
{
    [TestClass]
    public class TestyDTOAsortymentu
    {
        private static DtoAsortymentu DTO;
        private string zastanyOpis;
        private readonly string _symbolDostawy = "DOSTAWA";
        private readonly string _testowyOpis = "testowyOpis";
        private readonly int _indexBalsamuNawilzajacego200 = 0;
        private readonly int _idBalsamuNawilzajacego200 = 100000;
        private readonly int _idDostawy = 100003;

        [ClassInitialize]
        public static void TestFixtureSetUp(TestContext ctx)
        {
            DTO = new DtoAsortymentu();
        }

        [TestMethod]
        public void PodajWszystkieAsortymenty___Gdy_Zostanie_Wywolane_Poprawnie___Zwroci_Zawartosc_Tabeli_Asortymenty_Jako_Niepusta_Liste_Implementujaca_IBindingList()
        {
            // Działaj
            var produkty = DTO.PodajWszystkieAsortymenty();

            // Sprawdź
            produkty.Count.Should().BeGreaterThan(0);
            produkty.Should().BeAssignableTo<IBindingList>();
        }

        [TestMethod]
        public void PodajWszystkieAsortymenty___Gdy_Zostanie_Wywolane_Poprawnie___Encje_Zawarte_W_Liscie_Beda_Typu_Asortyment()
        {
            // Działaj
            var produkty = DTO.PodajWszystkieAsortymenty();

            // Sprawdź
            produkty[0].Should().BeOfType<Asortyment>();
        }

        [TestMethod]
        public void PodajKonkretnyAsortyment___Gdy_Przekaze_Poprawny_Symbol_Dostawy___Zwroci_Konkretna_encje()
        {
            //Działaj
            var asortyment = DTO.PodajKonkretnyAsortyment(_symbolDostawy);

            // Sprawdź
            asortyment.Dane.Id.Should().Be(_idDostawy);
        }

        [TestMethod]
        public void PodajKonkretnyAsortyment___Gdy_Przekaze_Poprawny_Index_Balsamu_Nawilzajacego_200___Zwroci_Odpowiednia_Encje()
        {
            //Działaj
            var asortyment = DTO.PodajKonkretnyAsortyment(_indexBalsamuNawilzajacego200);

            // Sprawdź
            asortyment.Id.Should().Be(_idBalsamuNawilzajacego200);
        }

        [TestMethod]
        public void ZmienOpis___Gdy_Przekaze_Opis_O_Dopuszczalnej_Wielkosci___Zmieni_Opis_W_Danym_Wierszu_W_DB()
        {
            // Przygotuj
            zastanyOpis = DTO.PodajKonkretnyAsortyment(_symbolDostawy).Dane.Opis;

            // Działaj
            DTO.ZmienOpis(_symbolDostawy, _testowyOpis);

            // Sprawdź
            DTO.PodajKonkretnyAsortyment(_symbolDostawy).Dane.Opis.Should().Be(_testowyOpis);

            // Przywróć
            DTO.ZmienOpis(_symbolDostawy, zastanyOpis);
        }
    }
}
