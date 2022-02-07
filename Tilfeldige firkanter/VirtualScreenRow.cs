using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldige_firkanter
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;
        public int ScreenWidth;


        public VirtualScreenRow(int width)
        {
            _cells = new VirtualScreenCell[width];
            for (int i = 0; i < width; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
        }


        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            var boxEnd = boxWidth - 1;

            _cells[boxX].AddUpperLeftCorner();
            for (int i = 1; i < boxEnd; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxEnd].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            var boxEnd = boxWidth - 1;

            _cells[boxX].AddLowerLeftCorner();
            for (int i = 1; i < boxEnd; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxEnd].AddLowerRightCorner();
        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            var boxEnd = boxWidth - 1;

            _cells[boxX].AddVertical();
            _cells[boxX + boxEnd].AddVertical();
        }

        public void Show()
        {
            var chars = _cells.Select(cell => cell.GetCharacter()).ToArray();
            Console.WriteLine(chars);
        }

    }
}
