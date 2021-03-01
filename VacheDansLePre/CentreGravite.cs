using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacheDansLePre
{
    class CentreGravite
    {
        public float xG { get; set; }
        public float yG { get; set; }

        public CentreGravite(float p_xG, float p_yG)
        {
            xG = p_xG;
            yG = p_yG;
        }

        public bool AppartenancePointPolygone(Polygone polygone,CentreGravite centreGravite)
        {
            float somme = 0.0f, thetai;
            byte i;
            for (i = 0; i < polygone.listePiquet.Count()-1; i++)
            {
                thetai = polygone.CalculAngles(centreGravite,polygone.listePiquet[i],polygone.listePiquet[i+1]) ;
                somme = somme + thetai;
                if (i == polygone.listePiquet.Count() - 2)
                {
                    thetai = polygone.CalculAngles(centreGravite, polygone.listePiquet[i+1], polygone.listePiquet[0]);
                    somme = somme + thetai;
                }
                
            }
            Console.WriteLine("somme : {0}", somme);
            Console.WriteLine("2pi: {0}", (float)Math.PI * 2);
            
            if (somme == (float)(2 * Math.PI))
                return true;
            else
                return false;
        }
    }
}
