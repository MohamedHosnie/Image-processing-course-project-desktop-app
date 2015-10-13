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
            string[] folders = _directory.Split('\\');
            file_name = folders[folders.Length - 1];
            bitmap = new Bitmap(_directory);
            height = bitmap.Height;
            width = bitmap.Width;
            max_color = 0;
            buffer2d = new Color[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    buffer2d[x, y] = bitmap.GetPixel(x, y);
                    if (buffer2d[x, y].R > max_color) max_color = buffer2d[x, y].R;
                    if (buffer2d[x, y].G > max_color) max_color = buffer2d[x, y].G;
                    if (buffer2d[x, y].B > max_color) max_color = buffer2d[x, y].B;
                }
            }
        }
        
    }
}
