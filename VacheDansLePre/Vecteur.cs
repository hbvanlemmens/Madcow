using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacheDansLePre
{
    class Vecteur
    {
        public float xV { get; set; }
        public float yV { get; set; }

        //constructeur de vecteur
        public Vecteur(float p_xV, float p_yV)
        {
            xV = p_xV;
            yV = p_yV;
        }

        //----------méthodes---------

        //Calcul des coordonées du vecteur 
        public void CalculCoordVecteur(CentreGravite centreGravite, Piquet p_piquet2)
        {
            xV = p_piquet2.xP - centreGravite.xG;
            yV = p_piquet2.yP - centreGravite.yG;
        }

        //Calcul d'un produit scalaire à partir de deux vecteurs
        public float CalculProdScalaire(Vecteur p_v1, Vecteur p_v2)
        {
            float produit;
            produit = p_v1.xV * p_v2.xV + p_v1.yV * p_v2.yV;
            return produit;
        }

        //Calcul de norme de vecteur
        public float CalculNormeVecteur(Vecteur p_v1)
        {
            float norme;
            norme = (float)Math.Sqrt(Math.Pow(p_v1.xV, 2) + Math.Pow(p_v1.yV, 2));//cast du calcul pour gérer le type
            return norme;
        }
    }
}
