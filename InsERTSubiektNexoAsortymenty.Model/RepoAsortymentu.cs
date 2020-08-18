using InsERT.Moria.Asortymenty;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsERTSubiektNexoAsortymenty.Model
{
    public class RepoAsortymentu : IRepoAsortymentu
    {
        public ICollection<IAsortyment> GetAsortyment()
        {
            throw new NotImplementedException();
        }

        public bool ZmienOpis(string Id, string nowyOpis)
        {
            throw new NotImplementedException();
        }
    }
}
