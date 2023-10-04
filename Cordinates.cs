using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public class Cordinates
    {
        public int x;
        public int y;

        public Cordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static bool operator ==(Cordinates c1, Cordinates c2)
        {
            return c1.x == c2.x && c1.y == c2.y;
        }
        public static bool operator !=(Cordinates c1, Cordinates c2)
        {
            return !(c1 == c2);
        }



    }
}
