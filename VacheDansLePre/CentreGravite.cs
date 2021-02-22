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

        public bool AppartenancePointPolygone(Polygone polygone)
        {
            return true;
        }
    }
}
