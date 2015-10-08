using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingTask1.Classes 
{
    class PPMImage : ImageP
    {
        public PPMImage(string _directory)
        {
            int flag = 0;
            StreamReader sr = new StreamReader(_directory);
            original_format = sr.ReadLine();
            flag = original_format.Length;
            while (sr.Peek() == '#')
            {
                string ln = sr.ReadLine();
                flag += ln.Length;
            }
            string size_str = sr.ReadLine();
            flag += size_str.Length;
            string[] size = size_str.Split(' ');
            width = Int32.Parse(size[0]);
            height = Int32.Parse(size[1]);
            bitmap = new Bitmap(width, height);
            string max_color = sr.ReadLine(); //max color
            flag += max_color.Length;
            
            if (original_format == "P3")
            {
                string Image_str = sr.ReadToEnd();
                string[] Image_array = Image_str.Split(' ');
                buffer2d = new Color[width, height];
                int z = 0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color color = Color.FromArgb(Int32.Parse(Image_array[z]), Int32.Parse(Image_array[z + 1]), Int32.Parse(Image_array[z + 2]));
                        buffer2d[x, y] = color;
                        bitmap.SetPixel(x, y, color);
                        z += 3;
                    }
                }

                sr.Close();
                
            }
            else if(original_format == "P6")
            {
                byte[] fl = File.ReadAllBytes(_directory);
                buffer2d = new Color[width, height];
                int z = flag + 1;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color color = Color.FromArgb(fl[z], fl[z + 1], fl[z + 2]);
                        buffer2d[x, y] = color;
                        bitmap.SetPixel(x, y, color);
                        z += 3;
                    }
                }

            }


        }
        public Color[,] get_buffer2d()
        {
            return buffer2d;
        }
    }
}
