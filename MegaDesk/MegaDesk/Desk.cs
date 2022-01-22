using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    class Desk
    {
        SurfaceMaterial material;
        public int width;
        public int depth;
        public int drawers;

        public Desk(SurfaceMaterial material, int width, int depth, int drawers)
        {
            this.material = material;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
        }
    }
}
