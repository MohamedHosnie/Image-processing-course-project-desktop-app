using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_FCIS.Classes
{
    class CommonImage : ImageP
    {
        public CommonImage(string _directory)
        {
            bitmap = new Bitmap(_directory);
            height = bitmap.Height;
            width = bitmap.Width;
        }
        public Color[,] get_buffer2d()
        {
            buffer2d = new Color[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    buffer2d[x, y] = bitmap.GetPixel(x, y);
                }
            }
            return buffer2d;
        }
    }
}
