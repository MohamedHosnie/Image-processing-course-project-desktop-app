using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace IP_FCIS.Classes
{
    public class TypicalImage
    {
        protected int width, height;
        public Bitmap bitmap;
        protected Color [,]buffer2d;
        protected string original_format;
        protected byte max_color;
        protected string file_name;
        protected int min_intensity, max_intensity;
        private int FWidth, FHeight;
        public enum Postprocessing
        {
            No,
            Normalization,
            Absolute,
            Cut_off
        }
        public enum Type
        {
            Common, PPM
        }
        public enum Interpolation
        {
            None, Bilinear
        }
        public TypicalImage() {    }
        public TypicalImage(Type type, string directory) 
        {
            if(type == Type.Common)
            {
                open_commom(directory);
            }
            else if(type == Type.PPM)
            {
                open_ppm(directory);
            }
            else
            {
                throw new Exception("Wrong type");
            }
        }
        public TypicalImage(TypicalImage img)
        {
            this.width = img.width;
            this.height = img.height;
            this.bitmap = new Bitmap(img.bitmap);
            this.buffer2d = new Color[width, height];
            for (int y = 0; y < this.height; y++)
            {
                for (int x = 0; x < this.width; x++)
                {
                    this.buffer2d[x, y] = img.buffer2d[x, y];
                }
            }
            this.original_format = img.original_format;
            this.max_color = img.max_color;
            this.file_name = img.file_name;
        }
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
        public string get_extension()
        {
            string []splited = file_name.Split('.');
            return splited[1];
        }
        public byte get_max_color()
        {
            return max_color;
        }
        public string get_file_name()
        {
            return file_name;
        }
        public void set_file_name(string name)
        {
            this.file_name = name;
        }
        public void open_commom(string _directory)
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
        public void open_ppm(string _directory)
        {
            string[] folders = _directory.Split('\\');
            file_name = folders[folders.Length - 1];
            int flag = 0;
            StreamReader sr = new StreamReader(_directory);
            original_format = sr.ReadLine();
            flag = original_format.Length + 1;
            while (sr.Peek() == '#')
            {
                string ln = sr.ReadLine();
                flag += ln.Length + 1;
            }
            string size_str = sr.ReadLine();
            flag += size_str.Length + 1;
            string[] size = size_str.Split(' ');
            width = Int32.Parse(size[0]);
            height = Int32.Parse(size[1]);
            bitmap = new Bitmap(width, height);
            string smax_color = sr.ReadLine();
            max_color = Convert.ToByte(smax_color);
            flag += smax_color.Length + 1;

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
            else if (original_format == "P6")
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
                        Color color = Color.FromArgb(R, G, B);
                        buffer2d[x, y] = color;
                        bitmap.SetPixel(x, y, color);
                        z += 3;
                    }
                }

            }


        }
        public void save_common(string fileName, ImageFormat imageFormat)
        {
            this.bitmap.Save(fileName, imageFormat);
        }
        public void save_ppm(string ppm_type, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
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

                    BinaryWriter bw = new BinaryWriter(new FileStream(fileName, FileMode.Append));
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
        public void scale(float ScaleX, float ScaleY, Interpolation interpol = Interpolation.Bilinear)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Scale(ScaleX, ScaleY);

            Transform(transform_matrix, interpol);
        }
        public void resize(float Width, float Height, Interpolation interpol = Interpolation.Bilinear)
        {
            Matrix transform_matrix = new Matrix();
            float ScaleX = Width / (float)width,
                  ScaleY = Height / (float)height;
            
            transform_matrix.Scale(ScaleX, ScaleY);

            Transform(transform_matrix, interpol);
        }
        public void rotate(float RotateAngle, Interpolation interpol = Interpolation.Bilinear)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Rotate(RotateAngle);

            Transform(transform_matrix, interpol);
        }
        public void shear(float ShearX, float ShearY, Interpolation interpol = Interpolation.Bilinear)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Shear(ShearX, ShearY);

            Transform(transform_matrix, interpol);
        }
        public void full_transform(float ScX, float ScY, float ShX, float ShY, float RoAngle, Interpolation interpol = Interpolation.Bilinear)
        {
            Matrix transform_matrix = new Matrix();
            transform_matrix.Shear(ShX, ShY, MatrixOrder.Append);
            transform_matrix.Rotate(RoAngle, MatrixOrder.Append);
            transform_matrix.Scale(ScX, ScY, MatrixOrder.Append);

            Transform(transform_matrix, interpol);
        }
        public void Transform(Matrix transform_matrix, Interpolation _interpolation = Interpolation.Bilinear)
        {
            PointF[] ps = new PointF[4];
            ps[0].X = 0; ps[0].Y = 0;
            ps[1].X = width; ps[1].Y = 0;
            ps[2].X = 0; ps[2].Y = height;
            ps[3].X = width; ps[3].Y = height;

            transform_matrix.TransformPoints(ps);

            float MinX = ps[0].X, MinY = ps[0].Y,
                MaxX = ps[0].X, MaxY = ps[0].Y;
            for (int i = 0; i < 4; i++)
            {
                if (ps[i].X < MinX) MinX = ps[i].X;
                if (ps[i].Y < MinY) MinY = ps[i].Y;
                if (ps[i].X > MaxX) MaxX = ps[i].X;
                if (ps[i].Y > MaxY) MaxY = ps[i].Y;
            }

            int new_width = (int)(MaxX - MinX);
            int new_height = (int)(MaxY - MinY);

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
                        switch (_interpolation)
                        {
                            case Interpolation.None:
                                new_buffer2d[x, y] = buffer2d[(Int32)pt[0].X, (Int32)pt[0].Y];
                                break;
                            case Interpolation.Bilinear:
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
        public void not()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = buffer2d[x, y];
                    Color newclr = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    buffer2d[x, y] = newclr;
                    bitmap.SetPixel(x, y, newclr);
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
        public void calculate_intensity_min_max()
        {
            int[][] his = new int[4][];
            his[0] = new int[256];
            his[1] = new int[256];
            his[2] = new int[256];
            his[3] = new int[256];
            histogram(ref his);

            bool min_found = false;
            for(int i = 0; i < 256; i++)
            {
                if(his[3][i] > 0)
                {
                    if (!min_found)
                    {
                        min_found = true;
                        min_intensity = i;

                    } else
                    {
                        max_intensity = i;
                    }
                    

                }

            }

        }
        public TypicalImage change_brightness(int add_value)
        {
            TypicalImage img = new TypicalImage(this);

            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color colr = this.buffer2d[x, y];
                    int R, G, B;
                    if (colr.R + add_value > 255) R = 255;
                    else if (colr.R + add_value < 0) R = 0;
                    else R = colr.R + add_value;
                    if (colr.G + add_value > 255) G = 255;
                    else if (colr.G + add_value < 0) G = 0;
                    else G = colr.G + add_value;
                    if (colr.B + add_value > 255) B = 255;
                    else if (colr.B + add_value < 0) B = 0;
                    else B = colr.B + add_value;

                    Color new_colr = Color.FromArgb(R, G, B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;
                }
            }

            return img;
        }
        public TypicalImage change_contrast(int _value)
        {
            TypicalImage img = new TypicalImage(this);            
            calculate_intensity_min_max();

            float oldmin = (float)min_intensity,
                oldmax = (float)max_intensity,
                newmin = oldmin - (float)_value,
                newmax = oldmax + (float)_value;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color colr = this.buffer2d[x, y];
                    float R = (colr.R - oldmin) / (oldmax - oldmin) * (newmax - newmin) + newmin,
                        G = (colr.G - oldmin) / (oldmax - oldmin) * (newmax - newmin) + newmin,
                        B = (colr.B - oldmin) / (oldmax - oldmin) * (newmax - newmin) + newmin;

                    if (R > 255) R = 255;
                    else if (R < 0) R = 0;
                    if (G > 255) G = 255;
                    else if (G < 0) G = 0;
                    if (B > 255) B = 255;
                    else if (B < 0) B = 0;
                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;
                }
            }

            return img;
        }
        public TypicalImage change_gamma(double gamma_value)
        {
            TypicalImage img = new TypicalImage(this);
            double[] buffer = new double[width * height * 3];
            
            double min = buffer2d[0, 0].R,
                   max = 0;

            int z = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, z += 3)
                {
                    Color colr = this.buffer2d[x, y];
                    double R, G, B;

                    if(gamma_value <= 0)
                    {
                        R = colr.R;
                        G = colr.G;
                        B = colr.B;

                    } else
                    {
                        R = Math.Pow(colr.R, gamma_value);
                        G = Math.Pow(colr.G, gamma_value);
                        B = Math.Pow(colr.B, gamma_value);
                    }

                    buffer[z] = R;
                    buffer[z + 1] = G;
                    buffer[z + 2] = B;

                    if (R > max) max = R;
                    if (R < min) min = R;
                    if (G > max) max = G;
                    if (G < min) min = G;
                    if (B > max) max = B;
                    if (B < min) min = B;

                }
            }
            normalization(buffer, img);

            //double newmin = 0,
            //newmax = 255;

            //z = 0;
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++, z += 3)
            //    {
            //        double R = (buffer[z] - min) / (max - min) * (newmax - newmin) + newmin,
            //               G = (buffer[z + 1] - min) / (max - min) * (newmax - newmin) + newmin,
            //               B = (buffer[z + 2] - min) / (max - min) * (newmax - newmin) + newmin;

                    

            //        Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
            //        img.bitmap.SetPixel(x, y, new_colr);
            //        img.buffer2d[x, y] = new_colr;
            //    }
            //}

            return img;
        }
        public TypicalImage Add(TypicalImage second, float fraction)
        {
            TypicalImage img = new TypicalImage(this);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = img.buffer2d[x, y];
                    Color color2 = second.buffer2d[x, y];


                    float R, G, B;
                    R = color1.R * fraction + color2.R * (1 - fraction);
                    G = color1.G * fraction + color2.G * (1 - fraction);
                    B = color1.B * fraction + color2.B * (1 - fraction);

                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;

                }
            }

            return img;
        }
        public TypicalImage Subtract(TypicalImage second)
        {
            TypicalImage img = new TypicalImage(this);

            double[] buffer = new double[width * height * 3];
            double min = buffer2d[0, 0].R;
            double max = buffer2d[0, 0].R;
            int z = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, z += 3)
                {
                    Color color1 = img.buffer2d[x, y];
                    Color color2 = second.buffer2d[x, y];


                    double R, G, B;
                    R = color1.R - color2.R;
                    G = color1.G - color2.G;
                    B = color1.B - color2.B;
                    buffer[z] = R;
                    buffer[z + 1] = G;
                    buffer[z + 2] = B;

                    if (R > max) max = R;
                    if (R < min) min = R;
                    if (G > max) max = G;
                    if (G < min) min = G;
                    if (B > max) max = B;
                    if (B < min) min = B;
                }
            }

            double newmin = 0, newmax = 255;
            z = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, z += 3)
                {
                    double R = (buffer[z] - min) / (max - min) * (newmax - newmin) + newmin,
                        G = (buffer[z + 1] - min) / (max - min) * (newmax - newmin) + newmin,
                       B = (buffer[z + 2] - min) / (max - min) * (newmax - newmin) + newmin;

                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;
                }

            }

            return img;
        }
        public TypicalImage bitplane(char color, int mask)
        {

            TypicalImage img = new TypicalImage(this);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = this.buffer2d[x, y];
                    float R = 255, G = 255, B = 255;

                    if (color == 'R')
                    {
                        R = color1.R & mask;
                        if (R == mask)
                        {
                            R = 255;
                            G = 0;
                            B = 0;
                        }
                        else
                        {
                            R = 245;
                            G = 245;
                            B = 245;
                        }
                            
                    }
                    else if (color == 'G')
                    {
                        G = color1.G & mask;
                        if (G == mask)
                        {
                            R = 0;
                            G = 255;
                            B = 0;
                        }
                        else
                        {
                            R = 245;
                            G = 245;
                            B = 245;
                        }
                    }
                    else if (color == 'B')
                    {
                        B = color1.B & mask;
                        if (B == mask)
                        {
                            R = 0;
                            G = 0;
                            B = 255;
                        }
                        else
                        {
                            R = 245;
                            G = 245;
                            B = 245;
                        }
                    }


                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;

                }

            }

            return img;
        }
        public TypicalImage bitplane_slicing(Color _color)
        {
            TypicalImage img = new TypicalImage(this);

            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    int R, G, B;

                    R = this.buffer2d[x, y].R & _color.R;
                    G = this.buffer2d[x, y].G & _color.G;
                    B = this.buffer2d[x, y].B & _color.B;

                    Color new_color = Color.FromArgb(R, G, B);
                    img.buffer2d[x, y] = new_color;
                    img.bitmap.SetPixel(x, y, new_color);
                }
            }

            return img;
        }
        public TypicalImage quantization(Int32 mask)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = this.buffer2d[x, y];
                    float R = 0, G = 0, B = 0;

                        R = color1.R & mask;
                        G = color1.G & mask;
                        B = color1.B & mask;

                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    this.bitmap.SetPixel(x, y, new_colr);
                    this.buffer2d[x, y] = new_colr;
                }
            }
            return this;
        }
        public TypicalImage padding(int padWidth, int padHeight)
        {

            int newwidth = width + padWidth * 2;
            int newheight = height + padHeight * 2;
            Color[,] newbuffer = new Color[newwidth, newheight];
            Bitmap tempbitmap = new Bitmap(newwidth, newheight);

            for (int y = 0; y < newheight; y++)
            {
                for (int x = 0; x < newwidth; x++)
                {
                    Color tempcolor;
                    if (y - padHeight < 0 || y - padHeight >= height || x - padWidth < 0 || x - padWidth >= width)
                        tempcolor = Color.FromArgb(0, 0, 0);
                    else
                        tempcolor = this.buffer2d[x - padWidth, y - padHeight];

                    newbuffer[x, y] =tempcolor ;
                    tempbitmap.SetPixel(x, y, tempcolor);
                }
            
            }

            this.width = newwidth;
            this.height = newheight;
            this.buffer2d = newbuffer;
            this.bitmap = tempbitmap;

            return this;

        }
        public TypicalImage LinearFilter(float[,] filter,int Origx, int Origy, Postprocessing post)
        {
            TypicalImage img = new TypicalImage(this);
            TypicalImage edited_img = new TypicalImage(this);
            int padWidth, padHeight;

            double[] buffer = new double[width * height * 3];
            int z = 0 ;
            padWidth = Math.Max(FWidth - Origx, Origx);
            padHeight = Math.Max(FHeight - Origy, Origy);
            img.padding(padWidth, padHeight);

            for (int y = padHeight; y < height + padHeight; y++)
            {
                for (int x = padWidth; x < width + padWidth; x++,z += 3)
                {

                    float R = 0, G = 0, B = 0;

                    for (int i = 0; i < FWidth; i++)
                    {
                        for (int j = 0; j < FHeight; j++)
                        {
                            R += img.buffer2d[x - Origx + i, y - Origy + j].R * filter[i, j];
                            G += img.buffer2d[x - Origx + i, y - Origy + j].G * filter[i, j];
                            B += img.buffer2d[x - Origx + i, y - Origy + j].B * filter[i, j];
                        }
                    }
                    buffer[z] = R;
                    buffer[z + 1] = G;
                    buffer[z + 2] = B;
                }
            }

            if (post == Postprocessing.Cut_off)
            {
               edited_img.cut_off(buffer);
            }
            else if (post == Postprocessing.No)
            {
                edited_img.no_postprocess(buffer);
            }
            else if (post == Postprocessing.Absolute)
            {
                edited_img.absolute(buffer);
            }
            else if (post == Postprocessing.Normalization)
            {
               edited_img.normalization(buffer, edited_img);
            }
            return edited_img;
        }
        public TypicalImage meanFilter(int filterwidth, int filterheight, int origx, int origy)
        {
            FWidth = filterwidth;
            FHeight = filterheight;
            float[,] filter = new float[filterwidth, filterheight];
            float filterValue = 1 / ((float)filterwidth * (float)filterheight);
            for (int i = 0; i < filterwidth; i++)
            {
                for (int j = 0; j < filterheight; j++) {
                    filter[i, j] = filterValue;
                }
            }
           return LinearFilter(filter, origx, origy, Postprocessing.No);

        }
        public TypicalImage gaussianFilter1(float sigma,int size)
        {
            float[,] filter = new float[size, size];
            FWidth = size ;
            FHeight = size;
            int origx = FWidth / 2;
            int origy = FHeight / 2;
            double sum = 0,x = -(size/2),y=-(size/2);
            for (int i = 0; i < size ; i++,x++)
            {
                for (int j = 0; j < size; j++,y++)
                {
                    double filtervalue =(x*x + y*y) / (2*sigma*sigma);
                    filter[i , j] = (float)Math.Exp(-(filtervalue));
                    sum += (float)Math.Exp(-(filtervalue));
                }
                y = -(size / 2);
            }

            for (int i = 0; i < size ; i++)
            {
                for (int j = 0; j < size ; j++)
                {
                    filter[i , j ] /=(float) sum ; 
                }
            }

            return LinearFilter(filter, origx, origy, Postprocessing.No);
        }
        public TypicalImage gaussianFilter2(float sigma)
        {
            int N = (int)((3.7*sigma) - 0.5);
            int size = 2 * N + 1;
            float[,] filter = new float[size, size];
            FWidth = size;
            FHeight = size;

            int origx = FWidth / 2;
            int origy = FHeight / 2;

            double x = -(size / 2), y = -(size / 2);

            for (int i = 0; i < size; i++, x++)
            {
                for (int j = 0; j < size; j++, y++)
                {
                    double filtervalue = (1/(2*Math.PI*sigma*sigma));
                    double filtervalue1 =(float)Math.Exp(- (x * x + y * y) / (2 * sigma * sigma));
                    filtervalue = filtervalue * filtervalue1;
                    filter[j , i ] = (float)filtervalue;
                }
                y = -(size / 2);
            }

            return LinearFilter(filter, origx, origy, Postprocessing.No);

        }
        public TypicalImage laplacianFilter()
        {
            FWidth = 3;
            FHeight = 3;
            float[,] filter = new float[3, 3];
            filter[0, 0] = -1;
            filter[1, 0] = -1;
            filter[2, 0] = -1;

            filter[0, 1] = -1;
            filter[1, 1] = 9;
            filter[2, 1] = -1;

            filter[0, 2] = -1;
            filter[1, 2] = -1;
            filter[2, 2] = -1;

            return LinearFilter(filter, 1, 1, Postprocessing.Cut_off);
        }
        public TypicalImage horizontal_sobel_filter()
        {
            FWidth = 3;
            FHeight = 3;
            float[,] filter = new float[3, 3];
            filter[0, 0] = -1;
            filter[1, 0] = -2;
            filter[2, 0] = -1;

            filter[0, 1] = 0;
            filter[1, 1] = 0;
            filter[2, 1] = 0;

            filter[0, 2] = 1;
            filter[1, 2] = 2;
            filter[2, 2] = 1;

            return LinearFilter(filter, 1, 1, Postprocessing.Absolute);

        }
        public TypicalImage vertical_sobel_filter()
        {
            FWidth = 3;
            FHeight = 3;
            float[,] filter = new float[3, 3];
            filter[0, 0] = -1;
            filter[1, 0] = 0;
            filter[2, 0] = 1;

            filter[0, 1] = -2;
            filter[1, 1] = 0;
            filter[2, 1] = 2;

            filter[0, 2] = -1;
            filter[1, 2] = 0;
            filter[2, 2] = 1;

            return LinearFilter(filter, 1, 1, Postprocessing.Absolute);

        }
        public TypicalImage edge_magnitude()
        {

            TypicalImage hor = this.horizontal_sobel_filter();
            TypicalImage ver = this.vertical_sobel_filter();
            TypicalImage mag = new TypicalImage(this);
            double [] buffer = new double[width*height *3];
            int z=0;
            for (int j = 0; j < this.height; j++)
            {
                for (int i = 0; i < this.width; i++, z += 3)
                {
                    int R = hor.buffer2d[i, j].R + ver.buffer2d[i, j].R;
                    int G = hor.buffer2d[i, j].G + ver.buffer2d[i, j].G;
                    int B = hor.buffer2d[i, j].B + ver.buffer2d[i, j].B;
                   
                    buffer[z] = R;
                    buffer[z + 1] = G;
                    buffer[z + 2] = B;
                    
                }
            }
            normalization(buffer,mag);
                return mag;

        }
        public TypicalImage custom_filter(float[,] filter,int width,int height, Postprocessing post)
        {
            FWidth = width;
            FHeight = height;

            return LinearFilter(filter, FWidth / 2, FHeight / 2, post);
        }
        public void cut_off(double[] buffer)
        {
            for (int z = 0; z < buffer.Length; z++)
            {
                if (buffer[z] > 255)
                    buffer[z] = 255;
                else if (buffer[z] < 0)
                    buffer[z] = 0;
            }
            int i = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++,i+=3)
                {
                   Color newcolor = Color.FromArgb((byte)buffer[i], (byte)buffer[i+1], (byte)buffer[i+2]);
                   this.buffer2d[x, y] = newcolor;
                   this.bitmap.SetPixel(x, y, newcolor);
                }
            }
        
        }
        public void no_postprocess(double [] buffer)
        {
            int i = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, i += 3)
                {
                    Color newcolor = Color.FromArgb((byte)buffer[i], (byte)buffer[i + 1], (byte)buffer[i + 2]);
                    this.buffer2d[x, y] = newcolor;
                    this.bitmap.SetPixel(x, y, newcolor);
                }
            }

        }
        public void absolute(double[] buffer)
        {
            for (int z = 0; z < buffer.Length; z++)
            {
              
                if (buffer[z] < 0)
                    buffer[z]=Math.Abs(buffer[z]);
            }
            int i = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, i += 3)
                {
                    Color newcolor = Color.FromArgb((byte)buffer[i], (byte)buffer[i + 1], (byte)buffer[i + 2]);
                    this.buffer2d[x, y] = newcolor;
                    this.bitmap.SetPixel(x, y, newcolor);
                }
            }
        }
        public void normalization(double[] buffer, TypicalImage image)
        {
            double min = buffer[0],
                          max = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
               
                if (buffer[i] > max) max = buffer[i];
                if (buffer[i] < min) min = buffer[i];
            }

            double newmin = 0,
                   newmax = 255;

            int z = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++, z += 3)
                {
                    double R = (buffer[z] - min) / (max - min) * (newmax - newmin) + newmin,
                           G = (buffer[z + 1] - min) / (max - min) * (newmax - newmin) + newmin,
                           B = (buffer[z + 2] - min) / (max - min) * (newmax - newmin) + newmin;



                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    image.bitmap.SetPixel(x, y, new_colr);
                    image.buffer2d[x, y] = new_colr;
                }
            }
        }
    }
}
