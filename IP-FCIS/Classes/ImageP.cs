using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;

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
                    sw.Write("P6\n");
                    sw.Write("# This file was saved by some simple app\n");
                    sw.Write(Convert.ToString(width) + " " + Convert.ToString(height) + "\n");
                    sw.Write(Convert.ToString(this.max_color) + "\n");

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
        public void scale(float ScaleX, float ScaleY)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Scale(ScaleX, ScaleY);

            Transform(transform_matrix);
        }
        public void rotate(float RotateAngle)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Rotate(RotateAngle);

            Transform(transform_matrix);
        }
        public void shear(float ShearX, float ShearY)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Shear(ShearX, ShearY);

            Transform(transform_matrix);
        }
        public void full_transform(float ScX, float ScY, float ShX, float ShY, float RoAngle)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Scale(ScX, ScY);
            transform_matrix.Shear(ShX, ShY);
            transform_matrix.Rotate(RoAngle);

            Transform(transform_matrix);
        }
        public void Transform(Matrix transform_matrix)
        {
            Point[] ps = new Point[4];
            ps[0].X = 0; ps[0].Y = 0;
            ps[1].X = width - 1; ps[1].Y = 0;
            ps[2].X = 0; ps[2].Y = height - 1;
            ps[3].X = width - 1; ps[3].Y = height - 1;

            transform_matrix.TransformPoints(ps);

            int MinX = ps[0].X, MinY = ps[0].Y,
                MaxX = ps[0].X, MaxY = ps[0].Y;
            for (int i = 0; i < 4; i++)
            {
                if (ps[i].X < MinX) MinX = ps[i].X;
                if (ps[i].Y < MinY) MinY = ps[i].Y;
                if (ps[i].X > MaxX) MaxX = ps[i].X;
                if (ps[i].Y > MaxY) MaxY = ps[i].Y;
            }

            int new_width = MaxX - MinX;
            int new_height = MaxY - MinY;

            transform_matrix.Translate(-MinX, -MinY);

            if(transform_matrix.IsInvertible)
            {
                transform_matrix.Invert();
            }

            bitmap = new Bitmap(new_width, new_height);

            Color[,] new_buffer2d = new Color[new_width, new_height];

            Point[] pt = new Point[1];
            for (int y = 0; y < new_height; y++)
            {
                for (int x = 0; x < new_width; x++)
                {
                    pt[0].X = x; pt[0].Y = y;
                    transform_matrix.TransformPoints(pt);
                    if (pt[0].X < width && pt[0].Y < height && pt[0].X >= 0 && pt[0].Y >= 0)
                        new_buffer2d[x, y] = buffer2d[pt[0].X, pt[0].Y];
                    else
                        new_buffer2d[x, y] = Color.FromArgb(0, 0, 0);
                }
            }

            width = new_width;
            height = new_height;
            buffer2d = new_buffer2d;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    bitmap.SetPixel(x, y, buffer2d[x, y]);
                }
            }



        }
    }

}
