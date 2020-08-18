﻿using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using InsERT.Mox.Product;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Model
{
    public class DtoAsortymentu : IDtoAsortymentu
    {
        private Uchwyt _sfera;
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

        public IList<Asortyment> PodajAsortyment()
        {
            if (_sfera == null)
                throw new InvalidOperationException("Najpierw ustanów połączenie ze Sferą");

            var menedzerAsortymentow = _sfera.PodajObiektTypu<IAsortymenty>();

            var dane =  menedzerAsortymentow.Dane.Wszystkie("Nazwa", "Opis");

            var rezultat = new List<Asortyment>();
            foreach(var dana in dane)
            {
                rezultat.Add(dana);
            }
            return rezultat;
        }

        public bool ZmienOpis(string Id, string nowyOpis)
        {
            if (_sfera == null)
                throw new InvalidOperationException("Najpierw ustanów połączenie ze Sferą");

            throw new NotImplementedException();
        }
    }
}