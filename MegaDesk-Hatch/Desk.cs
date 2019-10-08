using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hatch
{
    public class Desk
    {
        public enum DesktopMaterial
        {
            Laminate
            , Oak
            , Rosewood
            , Veneer
            , Pine
        }

        public float Width { get; set; }

        public float Depth { get; set; }


        public float SurfaceMaterial { get; set; }


        public float NumberOfDrawers { get; set; }

    }
}
