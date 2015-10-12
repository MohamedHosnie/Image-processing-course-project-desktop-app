using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_FCIS.Classes 
{
    class PPMImage : ImageP
    {
        public PPMImage(string _directory)
        {
            int flag = 0;
            StreamReader sr = new StreamReader(_directory);
            original_format = sr.ReadLine(); //Console.WriteLine(original_format);
            flag = original_format.Length+1;
            while (sr.Peek() == '#')
            {
                string ln = sr.ReadLine(); //Console.WriteLine(ln);
                flag += ln.Length+1;
            }
            string size_str = sr.ReadLine(); //Console.WriteLine(size_str);
            flag += size_str.Length+1;
            string[] size = size_str.Split(' ');
            width = Int32.Parse(size[0]);
            height = Int32.Parse(size[1]);
            bitmap = new Bitmap(width, height);
            string smax_color = sr.ReadLine(); //Console.WriteLine(smax_color); //max color 
            max_color = Convert.ToByte(smax_color);
            flag += smax_color.Length+1;
            
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
                        int R = Int32.Parse(Image_array[z]),
                            G = Int32.Parse(Image_array[z + 1]),
                            B = Int32.Parse(Image_array[z + 2]);
                        Color color = Color.FromArgb(R, G, B);
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
                int z = flag;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        byte R = fl[z],
                             G = fl[z + 1], 
                             B = fl[z + 2];
                        //Console.WriteLine(R + " " + G + " " + B);
                        Color color = Color.FromArgb(R, G, B);
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
