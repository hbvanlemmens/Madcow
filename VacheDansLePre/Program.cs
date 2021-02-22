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


          
        }
    }
}
