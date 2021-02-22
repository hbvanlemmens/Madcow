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

        public void CalculCoordVecteur(Piquet p_piquet1, Piquet p_piquet2)
        {

        }

        public static float CalculProdScalaire(Vecteur p_v1,Vecteur p_v2)
        {
            float produit = 0.0f;
            return produit;
        }

        public static float CalculNormeVecteur(Vecteur p_v1)
        {
            float norme = 0.0f;
            return norme;
        }

        /*public static float CalculAngles(Vecteur p_v1, Vecteur p_v2)       // placement incertain - sémantique de la fonction encore floue
        {
            float angle = 0.0f;
            return angle;
        }*/
    }
}
