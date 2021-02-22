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
            
        } 
         
        public void CalculAire()
        {
            
        }

        

    }
}
