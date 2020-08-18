using InsERT.Moria.Asortymenty;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Model
{
    public interface IRepoAsortymentu
    {
        ICollection<IAsortyment> GetAsortyment();

        bool ZmienOpis(string Id, string nowyOpis);
    }
}
