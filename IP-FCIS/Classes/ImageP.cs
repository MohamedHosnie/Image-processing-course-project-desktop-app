using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace IP_FCIS.Classes
{
    public class ImageP
    {
        protected int width, height;
        protected Bitmap bitmap;
        protected Color [,]buffer2d;
        protected string original_format;
        protected byte max_color;
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
        public byte get_max_color()
        {
            return max_color;
        }
        public void save_ppm(string ppm_type, string file_name)
        {
            using (StreamWriter sw = new StreamWriter(file_name))
            {
                if (ppm_type == "P3")
                {
                    sw.WriteLine("P3");
                    sw.WriteLine("# This file was saved by some simple app");
                    sw.WriteLine(Convert.ToString(width) + " " + Convert.ToString(height));
                    sw.WriteLine(Convert.ToString(this.max_color));
                    int count = 0;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            string pixel_color = 
                                Convert.ToString(buffer2d[x, y].R) + " " +
                                Convert.ToString(buffer2d[x, y].G) + " " +
                                Convert.ToString(buffer2d[x, y].B) + " ";
                            count += pixel_color.Length;
                            if(count > 70)
                            {
                                sw.Write("\n");
                                count = 0;
                            }
                            sw.Write(pixel_color);

                        }
                    }

                    sw.Close();
                }
                else if (ppm_type == "P6")
                {
                    sw.WriteLine("P6");
                    sw.WriteLine("# This file was saved by some simple app");
                    sw.WriteLine(Convert.ToString(width) + " " + Convert.ToString(height));
                    sw.WriteLine(Convert.ToString(this.max_color));

                    sw.Close();

                    BinaryWriter bw = new BinaryWriter(new FileStream(file_name, FileMode.Append));
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            bw.Write(buffer2d[x, y].R);
                            bw.Write(buffer2d[x, y].G);
                            bw.Write(buffer2d[x, y].B);
                        }
                    }

                    bw.Close();
                }

                System.Media.SystemSounds.Asterisk.Play();
            }

        }

    }
}
