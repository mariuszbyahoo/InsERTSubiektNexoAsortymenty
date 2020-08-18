using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using InsERT.Mox.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InsERTSubiektNexoAsortymenty
{
    public class DtoAsortymentu
    {
        private string _connectionString;
        private string _dbName;
        private string _login;
        private string _password;

        public DtoAsortymentu()
        {
            var jSettings = JToken.Parse(File.ReadAllText("appsettings.json"));
            _connectionString = (string)jSettings["connectionString"];
            _dbName = (string)jSettings["DbName"];
            _login = (string)jSettings["Login"];
            _password = (string)jSettings["Password"];
        }

        private Uchwyt PolaczZeSfera()
        {
            DanePolaczenia danePolaczenia = DanePolaczenia.Jawne(_connectionString, _dbName, true);
            MenedzerPolaczen mp = new MenedzerPolaczen();
            Uchwyt sfera = mp.Polacz(danePolaczenia, ProductId.Subiekt);
            sfera.ZalogujOperatora(_login, _password);
            return sfera;
        }

        public IList<Asortyment> PodajAsortyment()
        {
            using (var sfera = PolaczZeSfera())
            {
                var menedzerAsortymentow = sfera.PodajObiektTypu<IAsortymenty>();

                var dane = menedzerAsortymentow.Dane.Wszystkie();

                var rezultat = new List<Asortyment>();
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
