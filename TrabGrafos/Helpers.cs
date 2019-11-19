using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrabGrafos
{
    public static class Helpers
    {
        public static Color RandomColor()
        {
            Random r = new Random();
            int red = r.Next(255);
            int green = r.Next(255);
            int blue = r.Next(255);
            return Color.FromArgb(red, green, blue);
        } 

        public static void LA(List<Node> list)
        {

        }

        public static void MA(List<Node> list)
        {

        }
        

    }
}
