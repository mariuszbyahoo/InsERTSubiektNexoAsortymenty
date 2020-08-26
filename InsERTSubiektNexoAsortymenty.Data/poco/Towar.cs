using System;
using System.Collections.Generic;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Data.Poco
{

    public class Towar
    {
        public Towar(int idTowaru, string nazwa, decimal cena, string symbol, string opis)
        {
            IdTowaru = idTowaru;
            Nazwa = nazwa;
            Cena = cena;
            Symbol = symbol;
            Opis = opis;
            Ilosc = 1;
        }
        public int IdTowaru { get; }
        public string Nazwa { get; }
        public decimal Cena { get; }
        public string Symbol { get; }
        public int Ilosc { get; set; }
        private string opis;
        public string Opis
        {
            get { return opis; }
            set
            {
                opis = value;
            }
        }
    }
}
