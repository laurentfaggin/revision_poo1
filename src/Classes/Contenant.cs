using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public abstract class Contenant
    {
        protected decimal m_volume_contenant;
        protected decimal m_capacite;
        protected decimal m_volume_liquide;
        protected List<Liquide> m_liste_liquide = new List<Liquide>();

        protected decimal GetVolumeContenant
        {
            get { return this.m_volume_contenant; }
        }
        protected decimal SetVolumeContenant
        {
            set { this.m_volume_contenant = value; }
        }
        protected decimal GetCapacite
        {
            get { return this.m_capacite; }
        }
        protected decimal SetCapacite
        {
            set { this.m_capacite = value; }
        }

        protected List<Liquide> GetListeLiquide
        {
            get { return this.m_liste_liquide; }
        }

        protected decimal GetVolumeLiquide
        {
            get { return this.m_volume_liquide; }
        }
        protected decimal SetVolumeLiquide
        {
            set { this.m_volume_liquide=value; }
        }

        protected Contenant(){}

        public void AjouterLiquide(Liquide p_liquide)
        {
            if(p_liquide.QuantiteLiquide() < 0)
            {
                throw new ArgumentOutOfRangeException ("La quantite ne peut etre negative", nameof(p_liquide));
            }
            if (p_liquide.QuantiteLiquide() > this.m_capacite)
            {
                throw new ArgumentOutOfRangeException ("La quantite ne peut etre superieure a la capacite", nameof(p_liquide));
            }
            this.m_liste_liquide.Add(p_liquide);
            this.m_capacite -= p_liquide.QuantiteLiquide();
            this.m_volume_liquide+=p_liquide.QuantiteLiquide();
        }


        public void RetirerLiquide(decimal p_quantite)
        {
            if(p_quantite<0)
            {
                throw new ArgumentOutOfRangeException("La quantite ne peut etre null", nameof(p_quantite));
            }
            if(p_quantite>this.m_capacite)
            {
                this.m_capacite=0;
            }
            foreach(Liquide l in this.m_liste_liquide)
            {   
                decimal retrait = Math.Round((p_quantite*(l.QuantiteLiquide()/this.GetVolumeLiquide)),2);
                l.RetirerQuantiteLiquide(retrait);
                this.m_capacite+=retrait;
                this.m_volume_liquide-=retrait;
            }
        }

        public decimal QuantiteLiquide()
        {
            return this.m_volume_liquide;
        }

        public decimal TauxRemplissage()
        {
            return Math.Round(((this.m_volume_liquide/this.m_capacite)*100),2);
        }

        public override string ToString()
        {
            string message="";
            foreach(Liquide l in this.m_liste_liquide)
            {
                message+="\t"+l.ToString();
            }
            return @"Les differents produits presents dans le contenant "+this.GetType().Name+" sont: \n" +
            message+"\n"+
            "Volume utilise: "+this.m_volume_liquide+" ml\n"+
            "Taux de remplissage: "+this.TauxRemplissage().ToString()+" %";                           
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Contenant c = (Contenant)obj;

            if (m_volume_liquide != c.m_volume_liquide)
            {
                return false;
            }

            if (m_liste_liquide.Count != c.m_liste_liquide.Count)
            {
                return false;
            }

            for (int i = 0; i < m_liste_liquide.Count; i++)
            {
                if (!m_liste_liquide[i].Equals(c.m_liste_liquide[i]))
                {
                    return false;
                }
            }

            return true;    
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}