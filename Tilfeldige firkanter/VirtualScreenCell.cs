using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldige_firkanter
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }


        public char GetCharacter()
        {
            if (Up && Down && Left && Right) return '┼';  
            if (!Up && Down && Left && Right) return '┬';

            if (Up && Down && Left && !Right) return '┤';

            if (Up && Down && !Left && Right) return '├';

            if (Up && !Down && Left && Right) return '┴';


            if (Up && Down && !Left && !Right) return '│';
            if (!Up && !Down && Left && Right) return '─';

            if (Up && !Down && !Left && Right) return '└';
            if (Up && !Down && Left && !Right) return '┘';
            if (!Up && Down && !Left && Right) return '┌';
            
            if (!Up && Down && Left && !Right) return '┐';

            //Husk '' for chars og "" er for string. evt Convert-->
            if (!Up && !Down && !Left && !Right) return Convert.ToChar(" ");

            //Ikke i bruk:
            if (Up && !Down && !Left && !Right) return '╹';
            if (!Up && Down && !Left && !Right) return '╻';
            if (!Up && !Down && Left && !Right) return '╸';
            if (!Up && !Down && !Left && Right) return '╺';

            else return Convert.ToChar("X");
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }
        public void AddVertical()
        {
            Up = true;
            Down = true;
        }
        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }
        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }
        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }
        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}
