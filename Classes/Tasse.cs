using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public class Tasse: Contenant
    {
        public Tasse(string p_nom):base(p_nom)
        {
            this.SetVolumeContenant = 250;
        }
    }
}