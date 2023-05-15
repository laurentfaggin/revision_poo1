using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Tasse: Contenant
    {
        public Tasse():base()
        {
            this.SetCapacite = 250m*0.95m;
        }
    }
}
