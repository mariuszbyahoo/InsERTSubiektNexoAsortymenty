using System;
using System.Collections.Generic;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Data.poco
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
        }
        public int IdTowaru { get; }
        public string Nazwa { get; }
        public decimal Cena { get; }
        public string Symbol { get; }
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
