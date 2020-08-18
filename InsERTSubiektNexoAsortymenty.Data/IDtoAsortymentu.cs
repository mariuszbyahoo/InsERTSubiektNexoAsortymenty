using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Model
{
    public interface IDtoAsortymentu
    {
        IList<Asortyment> PodajAsortyment();

        bool ZmienOpis(string Id, string nowyOpis);
    }
}
