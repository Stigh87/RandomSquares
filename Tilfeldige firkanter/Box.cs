using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldige_firkanter
{
    public class Box
    {
        Random random = new Random();
        public int X { get; }
        public int Y { get; }
        public int StartY => Y;
        public int EndY => Y + Height;
        public int Width { get; }
        public int Height { get; }
        private int _minimumSize = 3;

        public Box(Random random, int maxX, int maxY)
        {
            //la inn -1 for å hindre at firkant kommer på "utsiden" av screen.
            Width = random.Next(_minimumSize, maxX-1);
            Height = random.Next(_minimumSize, maxY-1);
            X = random.Next(1, maxX - Width);
            Y = random.Next(1, maxY - Height);
        }

       
    }
}
