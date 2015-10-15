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
        protected string file_name;
        public Image get_bitmap()
        {
            return bitmap;
        }
        public Color[,] get_buffer2d()
        {
            return buffer2d;
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
        public string get_file_name()
        {
            return file_name;
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
            transform_matrix.Scale(ScX, ScY, MatrixOrder.Append);
            transform_matrix.Shear(ShX, ShY, MatrixOrder.Append);
            transform_matrix.Rotate(RoAngle, MatrixOrder.Append);

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

            transform_matrix.Translate(-MinX, -MinY, MatrixOrder.Append);

            if(transform_matrix.IsInvertible)
            {
                transform_matrix.Invert();
            }

            bitmap = new Bitmap(new_width, new_height);

            Color[,] new_buffer2d = new Color[new_width, new_height];

            PointF[] pt = new PointF[1];
            for (int y = 0; y < new_height; y++)
            {
                for (int x = 0; x < new_width; x++)
                {
                    pt[0].X = x; pt[0].Y = y;
                    transform_matrix.TransformPoints(pt);
                    if (pt[0].X < width - 1 && pt[0].Y < height - 1 && pt[0].X > 0 && pt[0].Y > 0)
                    {
                        Color color = Bilinear_Interpolate(pt[0]);
                        switch (Program.main_form.toolStripInterpolation.Text)
                        {
                            case "None":
                                new_buffer2d[x, y] = buffer2d[(Int32)pt[0].X, (Int32)pt[0].Y];
                                break;
                            case "Bilinear":
                                new_buffer2d[x, y] = color;
                                break;
                            default:
                                new_buffer2d[x, y] = buffer2d[(Int32)pt[0].X, (Int32)pt[0].Y];
                                break;
                        }
                        
                        
                    }
                    else
                    {
                        new_buffer2d[x, y] = Color.FromArgb(255, 255, 255);
                    }
                    bitmap.SetPixel(x, y, new_buffer2d[x, y]);

                }
            }

            width = new_width;
            height = new_height;
            buffer2d = new_buffer2d;

        }
        public Color Bilinear_Interpolate(PointF _point)
        {
            int X1 = (Int32)Math.Floor(_point.X);
            int X2 = X1 + 1;
            int Y1 = (Int32)Math.Floor(_point.Y);
            int Y2 = Y1 + 1;

            Color P1 = buffer2d[X1, Y1];
            Color P2 = buffer2d[X2, Y1];
            Color P3 = buffer2d[X1, Y2];
            Color P4 = buffer2d[X2, Y2];

            double Xfraction = _point.X - X1;
            double Yfraction = _point.Y - Y1;

            double R1, G1, B1,
                   R2, G2, B2,
                   R3, G3, B3;

            R1 = P1.R * (1 - Xfraction) + P2.R * Xfraction;
            G1 = P1.G * (1 - Xfraction) + P2.G * Xfraction;
            B1 = P1.B * (1 - Xfraction) + P2.B * Xfraction;

            R2 = P3.R * (1 - Xfraction) + P4.R * Xfraction;
            G2 = P3.G * (1 - Xfraction) + P4.G * Xfraction;
            B2 = P3.B * (1 - Xfraction) + P4.B * Xfraction;

            R3 = R1 * (1 - Yfraction) + R2 * Yfraction;
            G3 = G1 * (1 - Yfraction) + G2 * Yfraction;
            B3 = B1 * (1 - Yfraction) + B2 * Yfraction;

            return Color.FromArgb((int)R3, (int)G3, (int)B3);

        }
        public void gray_scale()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = buffer2d[x, y];
                    int gray = (color.R + color.G + color.B) / 3;
                    color = Color.FromArgb(gray, gray, gray);
                    buffer2d[x, y] = color;
                    bitmap.SetPixel(x, y, color);
                }
            }
        }
        public void histogram(ref int[][] histogram_data)
        {
            
            Array.Clear(histogram_data[0], 0, histogram_data[0].Length);
            Array.Clear(histogram_data[1], 0, histogram_data[1].Length);
            Array.Clear(histogram_data[2], 0, histogram_data[2].Length);
            Array.Clear(histogram_data[3], 0, histogram_data[3].Length);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = buffer2d[x, y];
                    histogram_data[0][color.R]++;
                    histogram_data[1][color.G]++;
                    histogram_data[2][color.B]++;

                    int gray = (color.R + color.G + color.B) / 3;
                    histogram_data[3][gray]++;
                }
            }


        }

    }


}
