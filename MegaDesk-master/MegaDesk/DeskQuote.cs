using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        Desk desk = new Desk(SurfaceMaterial.Oak, 10, 10, 4);
        string customerName;
        int rushOrder;
        int quoteDate;

        // calculate surface area
        public int calculateSurfaceArea()
        {
            return desk.width * desk.depth;
        }

        // calculate quote
        public void calculateQuote()
        {
            int area = calculateSurfaceArea();
            int total = area * desk.drawers;

            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Show();
            displayQuote.displayQuote(total);
        }
    }
}
