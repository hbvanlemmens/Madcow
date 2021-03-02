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

        public Vecteur(float p_xV, float p_yV)
        {
            xV = p_xV;
            yV = p_yV;
        }

        public void CalculCoordVecteur(CentreGravite centreGravite, Piquet p_piquet2)
        {
            xV = p_piquet2.xP - centreGravite.xG;
            yV = p_piquet2.yP - centreGravite.yG;
        }

        public float CalculProdScalaire(Vecteur p_v1, Vecteur p_v2)
        {
            float produit;
            produit = p_v1.xV * p_v2.xV + p_v1.yV * p_v2.yV;
            return produit;
        }

        public float CalculNormeVecteur(Vecteur p_v1)
        {
            float norme;
            norme = (float)Math.Sqrt(Math.Pow(p_v1.xV, 2) + Math.Pow(p_v1.yV, 2));
            return norme;
        }
    }
}
