using System;
using System.Collections.Generic;
using FluentAssertions;
using InsERT.Moria.ModelDanych;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsERTSubiektNexoAsortymenty.Data.Testy
{
    [TestClass]
    public class TestyDTOAsortymentu
    {
        [TestMethod]
        public void Podaj_Asortyment___Gdy_Zostanie_Wywolane_Poprawnie___Zwroci_Zawartosc_Tabeli_Asortymenty_Jako_Niepusta_Liste()
        {
            // Przygotuj
            var Dto = new DtoAsortymentu();
            // Działaj
            var produkty = Dto.PodajAsortyment();

            // Sprawdź
            produkty.Count.Should().BeGreaterThan(0);
            produkty.Should().BeOfType<List<Asortyment>>();
        }
    }
}
