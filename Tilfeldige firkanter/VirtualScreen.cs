using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfeldige_firkanter
{
    public class VirtualScreen
    {
        private VirtualScreenRow[] _rows;
        private int Width;
        private int Height;

        public VirtualScreen(int width, int height)
        {
            Width = width;
            Height = height;
            _rows = new VirtualScreenRow[Height];
            for (int i = 0; i < height; i++)
            {
                _rows[i] = new VirtualScreenRow(width);
            }
        }
        public void Add(Box box)
        {
            _rows[box.StartY].AddBoxTopRow(box.X, box.Width);
            for (int i = box.StartY + 1; i < box.EndY; i++)
            {
                _rows[i].AddBoxMiddleRow(box.X, box.Width);
            }
            _rows[box.EndY].AddBoxBottomRow(box.X, box.Width);
        }
        public void Show()
        {
            Console.Clear();
            foreach (var screenRow in _rows)
            {
                screenRow.Show();
            }
        }
    }
}
