using InsERT.Moria.ModelDanych;

namespace InsERTSubiektNexoAsortymenty.Data.Poco
{
    public class KlientInfo
    {
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public int Id { get; set; }
        public KlientInfo(Podmiot podmiot)
        {
            Nazwa = podmiot.NazwaSkrocona;
            NIP = podmiot.NIP;
            Id = podmiot.Id;
        }

        public override string ToString()
        {
            var rezultat = this.Nazwa;
            if (NIP.Length > 0) rezultat += $", NIP: {this.NIP}";
            return rezultat;
        }
    }
}