using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    public abstract class Contenant
    {
        protected string m_nom;
        protected decimal m_volume_contenant;
        protected decimal m_capacite => m_volume_contenant*0.95;
        protected decimal m_volume_liquide;
        protected List<Liquide> m_liste_liquide = new List<Liquide>();

        protected string GetNom
        {
            get{ return this.m_nom; }
        }
        protected string SetNom
        {
            set { this.m_nom = value; }
        }

        protected decimal GetVolumeContenant
        {
            get { return this.m_volume_contenant; }
        }
        protected decimal SetVolumeContenant
        {
            set { this.m_volume_contenant = value; }
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

        protected Contenant(string p_nom)
        {
            this.m_nom = p_nom;
        }

        public void AjouterLiquide(Liquide p_liquide, decimal p_quantite)
        {
            if(p_quantite < 0)
            {
                throw new ArgumentOutOfRangeException ("La quantite ne peut etre negative", nameof(p_quantite));
            }
            if (p_quantite > this.m_capacite)
            {
                p_quantite=this.m_capacite;
            }
            this.m_liste_liquide.Add(p_liquide);
            this.m_capacite -= p_quantite;
            this.m_volume_liquide+=p_quantite;
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
            foreach(Liquide l in this.m_liste_liquides)
            {   
                decimal retrait = p_quantite*(l.QuantiteLiquide()/this.GetVolumeLiquide);
                l.RetirerQuantiteLiquide(retrait);
                this.m_capacite+=retrait;
                this.m_volume_liquide-=retrait;
            }
        }

        public override string ToString()
        {
            string message="";
            foreach(Liquide l in this.m_liste_liquide)
            {
                message+="\t"+l.ToString();
            }
            return @"Les differents produits presents dans le contenant "+this.GetType()+" sont: \n" +
            "\t"+message+"\n"+
            "Volume utilise: "+this.GetVolumeLiquide+"\n"+
            "Pourcentage de remplissage: "+(this.m_volume_liquide*this.m_capacite)/100;                           
        }
    }
}