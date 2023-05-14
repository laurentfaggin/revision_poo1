using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public class Bol: Contenant
    {
        public Bol(): base()
        {
            this.SetCapacite = 350m*0.95m;
        }
    }


}