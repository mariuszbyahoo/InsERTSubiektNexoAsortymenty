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
        private readonly string symbolDostawy = "DOSTAWA";
        private readonly int indexBalsamuNawilzajacego200 = 0;
        private readonly int idBalsamuNawilzajacego200 = 100000;
        private readonly int idDostawy = 100003;

        [TestMethod]
        public void PodajWszystkieAsortymenty___Gdy_Zostanie_Wywolane_Poprawnie___Zwroci_Zawartosc_Tabeli_Asortymenty_Jako_Niepusta_Liste_Implementujaca_IBindingList()
        {
            // Przygotuj
            var dto = new DtoAsortymentu();
            // Działaj
            var produkty = dto.PodajWszystkieAsortymenty();

            // Sprawdź
            produkty.Count.Should().BeGreaterThan(0);
            produkty.Should().BeAssignableTo<IBindingList>();
        }

        [TestMethod]
        public void PodajWszystkieAsortymenty___Gdy_Zostanie_Wywolane_Poprawnie___Encje_Zawarte_W_Liscie_Beda_Typu_Asortyment()
        {
            // Przygotuj
            var dto = new DtoAsortymentu();
            // Działaj
            var produkty = dto.PodajWszystkieAsortymenty();

            // Sprawdź
            produkty[0].Should().BeOfType<Asortyment>();
        }

        [TestMethod]
        public void PodajKonkretnyAsortyment___Gdy_Przekaze_Poprawny_Symbol_Dostawy___Zwroci_Konkretna_encje()
        {
            // Przygotuj
            var dto = new DtoAsortymentu();
            //Działaj
            var asortyment = dto.PodajKonkretnyAsortyment(symbolDostawy);

            // Sprawdź
            asortyment.Dane.Id.Should().Be(idDostawy);
        }

        [TestMethod]
        public void PodajKonkretnyAsortyment___Gdy_Przekaze_Poprawny_Index_Balsamu_Nawilzajacego_200___Zwroci_Odpowiednia_Encje()
        {
            // Przygotuj
            var dto = new DtoAsortymentu();
            //Działaj
            var asortyment = dto.PodajKonkretnyAsortyment(indexBalsamuNawilzajacego200);

            // Sprawdź
            asortyment.Id.Should().Be(idBalsamuNawilzajacego200);
        }
    }
}
