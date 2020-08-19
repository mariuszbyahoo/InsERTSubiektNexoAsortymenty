using FluentAssertions;
using InsERT.Moria.ModelDanych;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsERTSubiektNexoAsortymenty.Data.Testy
{
    [TestClass]
    public class TestySerwisuWalut
    {
        [TestMethod]
        public void PodajSymbolWaluty___Gdy_Wywołany_Poprawnie___Zwroci_Niepusta_Liste_Walut()
        {
            // przygotuj
            var dto = new SerwisWalut();
            // działaj
            var waluty = dto.PodajWaluty();

            // Sprawdź
            waluty.Count.Should().BeGreaterThan(0);
            waluty.Should().BeAssignableTo<IList<Waluta>>();
        }
    }
}
