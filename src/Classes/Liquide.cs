using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public abstract class Liquide
    {
        protected decimal m_quantite;

        public decimal GetQuantite
        {
            get { return this.m_quantite; }
        }    
        private decimal SetQuantite
        {
            set { this.m_quantite=value; }
        }

        public Liquide(decimal p_quantite)
        {
            this.m_quantite=p_quantite;
        }    

        public decimal QuantiteLiquide()
        {
            return this.m_quantite;
        }  
        public void RetirerQuantiteLiquide(decimal p_quantite)
        {
            this.m_quantite -= p_quantite;
        }

        public override string ToString()
        {
            return "\t"+this.GetType().Name+": "+this.m_quantite+" ml\n";
        }
    }


}