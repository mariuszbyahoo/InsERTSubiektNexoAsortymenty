using InsERT.Moria.ModelDanych;

namespace InsERTSubiektNexoAsortymenty
{
    public class KlientInfo
    {
        public string NazwaSkrocona { get; set; }
        public string NIP { get; set; }
        public KlientInfo(Podmiot podmiot)
        {
            NazwaSkrocona = podmiot.NazwaSkrocona;
            NIP = podmiot.NIP;
        }

        public override string ToString()
        {
            return $"{this.NazwaSkrocona}, NIP: {this.NIP}";
        }
    }
}