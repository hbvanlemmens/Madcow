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
        //constructeur
        public CentreGravite(float p_xG, float p_yG)
        {
            xG = p_xG;
            yG = p_yG;
        }
        //methode
        public bool AppartenancePointPolygone(Polygone polygone,CentreGravite centreGravite)
        {
            float somme = 0.0f, thetai;
            float deuxpi= (float)(2 * Math.PI);
            byte i;
            for (i = 0; i < polygone.listePiquet.Count()-1; i++)
            {
                thetai = polygone.CalculAngles(centreGravite,polygone.listePiquet[i],polygone.listePiquet[i+1]) ;
                //Console.WriteLine("\t{0}", thetai);
                somme = somme + thetai;
                //Console.WriteLine("\t{0}",somme);
                if (i == polygone.listePiquet.Count() - 2)
                {
                    thetai = polygone.CalculAngles(centreGravite, polygone.listePiquet[i+1], polygone.listePiquet[0]);
                    //Console.WriteLine("\t\t{0}", thetai);
                    somme = somme + thetai;
                    //Console.WriteLine("\t\t{0}", somme);
                }
                

            }

            somme = (float)Math.Round(somme, 6);
            deuxpi = (float)Math.Round(deuxpi, 6);
            Console.WriteLine("somme : {0}", somme);
            Console.WriteLine("2pi: {0}", deuxpi);


            if (somme == deuxpi)
                return true;
            else
                return false;
        }
    }
}
