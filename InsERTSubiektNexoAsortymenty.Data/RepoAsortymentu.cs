using InsERT.Moria.Asortymenty;
using InsERT.Moria.Sfera;
using InsERT.Mox.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Model
{
    public class RepoAsortymentu : IRepoAsortymentu
    {
        private Uchwyt _sfera;
        private string _connectionString;
        private string _dbName;
        private string _login;
        private string _password;

        public RepoAsortymentu()
        {
            var jSettings = JToken.Parse(File.ReadAllText("appsettings.json"));
            _connectionString = (string)jSettings["connectionString"];
            _dbName = (string)jSettings["DbName"];
            _login = (string)jSettings["Login"];
            _password = (string)jSettings["Password"];
            PolaczZeSfera();
        }

        private void PolaczZeSfera()
        {
            DanePolaczenia danePolaczenia = DanePolaczenia.Jawne(_connectionString, _dbName, true);
            MenedzerPolaczen mp = new MenedzerPolaczen();
            Uchwyt sfera = mp.Polacz(danePolaczenia, ProductId.Subiekt, ProductId.Rewizor);
            sfera.ZalogujOperatora(_login, _password);
            _sfera = sfera;
        }

        public ICollection<IAsortyment> GetAsortyment()
        {
            if (_sfera == null)
                throw new InvalidOperationException("Najpierw ustanów połączenie ze Sferą");

            throw new NotImplementedException();
        }

        public bool ZmienOpis(string Id, string nowyOpis)
        {
            if (_sfera == null)
                throw new InvalidOperationException("Najpierw ustanów połączenie ze Sferą");

            throw new NotImplementedException();
        }
    }
}
