using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using InsERT.Mox.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace InsERTSubiektNexoAsortymenty
{
    public class DtoAsortymentu : BazoweDto
    {
        public IList<Asortyment> PodajAsortyment()
        {
            using (var sfera = PolaczZeSfera())
            {
                var menedzerAsortymentow = sfera.PodajObiektTypu<IAsortymenty>();

                var dane = menedzerAsortymentow.Dane.Wszystkie();

                var rezultat = new BindingList<Asortyment>();
                foreach (var dana in dane)
                {
                    rezultat.Add(dana);
                }
                return rezultat;
            }
        }

        public bool ZmienOpis(string Id, string nowyOpis)
        {
            throw new NotImplementedException();
        }
    }
}
