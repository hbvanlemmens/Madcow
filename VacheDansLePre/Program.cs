using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacheDansLePre
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb_piquet=0;
            bool valid=true;
            float p_x, p_y;
            List<Piquet> listePiquet = new List<Piquet>();
            Polygone Enclos = new Polygone(listePiquet);

            //On indique le nombre de piquets en vérifiant le format de ce qui est rentré
            do
            {
                Console.WriteLine("Saisir le nombre de piquets ");
                try
                {
                    nb_piquet = Convert.ToInt32(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisir un nombre valide");
                    valid = false;
                }

            } while (!valid);


            //.Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            //On rentre maintenant les coordonnées des piquets
            while (nb_piquet!=0)
            {
                Console.WriteLine("Saisir le piquet {0} ", nb_piquet);

                Console.WriteLine("X");
                p_x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Y");
                p_y = Convert.ToSingle(Console.ReadLine());

                Enclos.listePiquet.Add(new Piquet(p_x, p_y));
                nb_piquet--;
            }

            //CALCULS
            Enclos.CalculAire();
            Console.WriteLine("Aire = {0}", Enclos.airePolygone);
            Enclos.airePolygone = Math.Abs(Enclos.airePolygone);
            Console.WriteLine("Aire = {0} valeur absolue\n", Enclos.airePolygone);

            Enclos.CalculCentreGravite();
            Console.WriteLine("Centre de gravité = abscisse : {0}, ordonnée : {1} ", Enclos.centreGravite.xG, Enclos.centreGravite.yG);

            valid = Enclos.centreGravite.AppartenancePointPolygone(Enclos, Enclos.centreGravite);
            
            //VERIFICATION FINALE
            if (valid)
                Console.WriteLine("La vache est dans le pré");
            else
                Console.WriteLine("La vache n'est pas dans le pré");
            

            Console.ReadLine();

        }
    }
}
