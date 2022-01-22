using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        Desk desk = new Desk(SurfaceMaterial.Oak, 5, 2, 2);
        public string customerName = "Adam";
        public int rushOrder;
        int quoteDate;

        // calculate surface area
        public int calculateSurfaceArea()
        {
            return desk.width * desk.depth;
        }

        // calculate rush order
        public int calcRushOrder(int total)
        {
            if (total < 1000)
            {
                total += 60;
            }
            else if ((total > 1000) && (total < 2000) )
            {
                total += 70;
            }
            else
            {
                total += 80;
            }
            return total;
        }

        // calculate quote
        public void calculateQuote()
        {
            int area = calculateSurfaceArea();
            int total = 200 + area + (desk.drawers * 50) + 200;

            int calculateRush = calcRushOrder(total);

            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Show();
            displayQuote.displayQuote(calculateRush);
        }
    }
}
