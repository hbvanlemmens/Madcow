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
            Enclos.CalculAire();
            Console.WriteLine("Aire = {0}", Enclos.airePolygone);
            Enclos.airePolygone = Math.Abs(Enclos.airePolygone);
            Console.WriteLine("Aire = {0} valeur absolue\n", Enclos.airePolygone);

            Enclos.CalculCentreGravite();
            Console.WriteLine("Centre de gravité = abscisse : {0}, ordonnée : {1} ", Enclos.centreGravite.xG, Enclos.centreGravite.yG);

            Console.ReadLine();

        }
    }
}
