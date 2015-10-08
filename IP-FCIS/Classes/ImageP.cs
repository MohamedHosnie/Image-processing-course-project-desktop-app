using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessingTask1.Classes
{
    class ImageP
    {
        protected int width, height;
        protected Bitmap bitmap;
        protected Color [,]buffer2d;
        protected string original_format;
        public Image get_bitmap()
        {
            return bitmap;
        }
        public int get_width()
        {
            return width;
        }
        public int get_height()
        {
            return height;
        }
        public string get_original_format()
        {
            return original_format;
        }
    }
}
