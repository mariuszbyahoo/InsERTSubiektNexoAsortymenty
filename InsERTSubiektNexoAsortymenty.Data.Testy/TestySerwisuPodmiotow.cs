using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using InsERTSubiektNexoAsortymenty.Data.Serwisy;

namespace InsERTSubiektNexoAsortymenty.Data.Testy
{

    [TestClass]
    public class TestySerwisuPodmiotow
    {
        public TestySerwisuPodmiotow()
        {

        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PodajWszystkiePodmioty___Gdy_Wywolany___Zwroci_Liste_Podmiotow_W_Bazie()
        {
            // Przygotuj
            var srv = new SerwisPodmiotow();
            // Działaj
            var podmioty = srv.PodajWszystkiePodmioty();

            // Sprawdź
            podmioty.Should().NotBeEmpty();
        }

        [TestMethod]
        public void PodajWszystkieFirmy___Gdy_Wywolany___Zwroci_Wszystkie_Firmy_W_Bazie()
        {
            // Przygotuj
            var srv = new SerwisPodmiotow();
            // Działaj
            var podmioty = srv.PodajWszystkieFirmy();

            // Sprawdź
            podmioty.Should().NotBeEmpty();
        }
    }
}
