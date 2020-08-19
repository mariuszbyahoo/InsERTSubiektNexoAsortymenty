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
        [TestMethod]
        public void PodajAsortyment___Gdy_Zostanie_Wywolane_Poprawnie___Zwroci_Zawartosc_Tabeli_Asortymenty_Jako_Niepusta_Liste_Implementujaca_IBindingList()
        {
            // Przygotuj
            var Dto = new DtoAsortymentu();
            // Działaj
            var produkty = Dto.PodajAsortyment();

            // Sprawdź
            produkty.Count.Should().BeGreaterThan(0);
            produkty.Should().BeAssignableTo<IBindingList>();
        }

        [TestMethod]
        public void PodajAsortyment___Gdy_Zostanie_Wywolane_Poprawnie___Encje_Zawarte_W_Liscie_Beda_Typu_Asortyment()
        {
            // Przygotuj
            var Dto = new DtoAsortymentu();
            // Działaj
            var produkty = Dto.PodajAsortyment();

            // Sprawdź
            produkty[0].Should().BeOfType<Asortyment>();
        }
    }
}
