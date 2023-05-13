using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public abstract class Liquide
    {
        protected Produits m_produit;
        protected decimal m_quantite;

        public string GetProduit
        {
            get {return this.m_produit; }
        }
        
        public decimal GetQuantite
        {
            get { return this.m_quantite; }
        }    
        public decimal SetQuantite
        {
            set { this.m_quantite=value; }
        }

        public Liquide(Produits p_produit)
        {
            this.m_produit=p_produit;
        }

        public void RetirerQuantiteLiquide( Produits p_produit, decimal p_quantite)
        {
            this.m_quantite -= p_quantite;
        }
    }


}