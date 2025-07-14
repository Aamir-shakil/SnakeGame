using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Coord
    {
        private int x;
        private int y;

        // Public read-only property to access the x coordinate
        public int X
        {
            get { return x; }
        }

        // Public read-only property to access the y coordinate
        public int Y
        {
            get { return y; }
        }

        public Coord(int x, int y) {
            this.x = x;
            this.y = y; 
        }

        
    }
    }


