using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacheDansLePre
{
    class Polygone
    {
        public List<Piquet> listePiquet = new List<Piquet>();

        public float airePolygone { get; set; }
        public CentreGravite centreGravite = new CentreGravite(0,0);

        public Polygone(List<Piquet> p_listePiquet)
        {
            listePiquet = p_listePiquet;
            airePolygone = 0.0f;
            centreGravite.xG = 0.0f;
            centreGravite.yG = 0.0f;
        }
        public void CalculCentreGravite()
        {
            float somme_x = 0;
            float somme_y = 0;
            for (byte i = 0; i < listePiquet.Count() - 1; i++)
            {
                somme_x = somme_x + ((listePiquet[i].xP + listePiquet[i + 1].xP)*(listePiquet[i].xP * listePiquet[i + 1].yP - listePiquet[i + 1].xP * listePiquet[i].yP));
                if (i == listePiquet.Count() - 2)
                    somme_x = somme_x + ((listePiquet[i+1].xP + listePiquet[0].xP )* (listePiquet[i+1].xP * listePiquet[0].yP - listePiquet[0].xP * listePiquet[i+1].yP));
            }

            for (byte i = 0; i < listePiquet.Count() - 1; i++)
            {
                somme_y = somme_y + ((listePiquet[i].yP + listePiquet[i + 1].yP) * (listePiquet[i].xP * listePiquet[i + 1].yP - listePiquet[i + 1].xP * listePiquet[i].yP));
                if (i == listePiquet.Count() - 2)
                    somme_y = somme_y + ((listePiquet[i+1].yP + listePiquet[0].yP) * (listePiquet[i+1].xP * listePiquet[0].yP - listePiquet[0].xP * listePiquet[i+1].yP));
            }

            centreGravite.xG = (float)(1 / (6 * airePolygone)*somme_x);
            centreGravite.yG = (float)(1 / (6 * airePolygone)*somme_y);
        }

        public void CalculAire()
        {
            float somme = 0;
            for (byte i = 0; i < listePiquet.Count() - 1; i++)//4 itération 0-3 pour l'exemple du cours
            {
                somme = somme + (listePiquet[i].xP * listePiquet[i + 1].yP - listePiquet[i + 1].xP * listePiquet[i].yP);
                if (i == listePiquet.Count() - 2) //i==2 arrivé a la 3ième itération
                    somme = somme + (listePiquet[i + 1].xP * listePiquet[0].yP - listePiquet[0].xP * listePiquet[i + 1].yP); //réglage modulo n
            }

            airePolygone = (float)0.5 * somme;
        }

        public float CalculAngles(CentreGravite centre, Piquet p_v1, Piquet p_v2)
        {
            Vecteur vect_a = new Vecteur(0, 0);
            Vecteur vect_b = new Vecteur(0, 0);
            vect_a.CalculCoordVecteur(centre, p_v1);// vecteur GSi
            vect_b.CalculCoordVecteur(centre, p_v2);// vecteur GSi+1
            float angle;
            angle = (float)Math.Acos(vect_a.CalculProdScalaire(vect_a, vect_b) / vect_a.CalculNormeVecteur(vect_a) * vect_b.CalculNormeVecteur(vect_b));
            return angle;
        }

    }
}
