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
        protected int min_intensity, max_intensity;
        private int FWidth, FHeight;
        public enum Postprocessing
        {
            No,
            Normalization,
            Absolute,
            Cut_off
        }

        public ImageP() { 
        }
        public ImageP(ImageP img)
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
        public void resize(float Width, float Height)
        {
            Matrix transform_matrix = new Matrix();
            float ScaleX = Width / (float)width,
                  ScaleY = Height / (float)height;
            
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
        public ImageP change_brightness(int add_value)
        {
            ImageP img = new ImageP(this);

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
        public ImageP change_contrast(int _value)
        {
            ImageP img = new ImageP(this);            
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
        public ImageP change_gamma(double gamma_value)
        {
            ImageP img = new ImageP(this);
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

            double newmin = 0,
            newmax = 255;

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
        public ImageP Add(ImageP second, float fraction)
        {
            ImageP img = new ImageP(this);

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
        public ImageP Subtract(ImageP second)
        {
            ImageP img = new ImageP(this);

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
        public ImageP bitplane(char color, int mask)
        {

            ImageP img = new ImageP(this);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = this.buffer2d[x, y];
                    float R = 0, G = 0, B = 0;

                    if (color == 'R')
                    {
                        R = color1.R & mask;
                        if (R == mask)
                            R = 255;
                        else
                            R = 0;
                        G = 0;
                        B = 0;
                    }
                    else if (color == 'G')
                    {
                        G = color1.G & mask;
                        if (G == mask)
                            G = 255;
                        else
                            G = 0;
                        R = 0;
                        B = 0;
                    }
                    else if (color == 'B')
                    {
                        B = color1.B & mask;
                        if (B == mask)
                            B = 255;
                        else
                            B = 0;
                        G = 0;
                        R = 0;
                    }


                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    img.bitmap.SetPixel(x, y, new_colr);
                    img.buffer2d[x, y] = new_colr;

                }

            }

            return img;
        }
        public ImageP bitPlane_remove(char color, int mask)
        {

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = this.buffer2d[x, y];
                    float R = 0, G = 0, B = 0;

                    if (color == 'R')
                    {
                        R = color1.R & mask;
                        G = color1.G;
                        B = color1.B;
                    }
                    else if (color == 'G')
                    {
                        R = color1.R;
                        G = color1.G & mask;
                        B = color1.B;
                    }
                    else if (color == 'B')
                    {
                        R = color1.R;
                        G = color1.G;
                        B = color1.B & mask;
                    }
                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    this.bitmap.SetPixel(x, y, new_colr);
                    this.buffer2d[x, y] = new_colr;
                }
            }
            return this;
        }
        public ImageP bitplane_slicing(Color _color)
        {
            ImageP img = new ImageP(this);

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
        public ImageP bitplane_add(char color, int mask)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = this.buffer2d[x, y];
                    float R = 0, G = 0, B = 0;

                    if (color == 'R')
                    {
                        R = color1.R | mask;
                        G = color1.G;
                        B = color1.B;
                    }
                    else if (color == 'G')
                    {
                        R = color1.R;
                        G = color1.G | mask;
                        B = color1.B;
                    }
                    else if (color == 'B')
                    {
                        R = color1.R;
                        G = color1.G;
                        B = color1.B | mask;
                    }
                    Color new_colr = Color.FromArgb((int)R, (int)G, (int)B);
                    this.bitmap.SetPixel(x, y, new_colr);
                    this.buffer2d[x, y] = new_colr;
                }
            }
            return this;
        }
        public ImageP quantization(Int32 mask)
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
        public ImageP padding(int padWidth, int padHeight)
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
        public ImageP LinearFilter(float[,] filter,int Origx, int Origy, Postprocessing post)
        {
            ImageP img = new ImageP(this);
            int padWidth, padHeight;
            padWidth = Math.Max(FWidth - Origx, Origx);
            padHeight = Math.Max(FHeight - Origy, Origy);
            img.padding(padWidth, padHeight);

            for (int y = padHeight; y < height + padHeight; y++)
            {
                for (int x = padWidth; x < width + padWidth; x++)
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

                    Color newcolor = Color.FromArgb((byte)R, (byte)G, (byte)B);
                    this.buffer2d[x - padWidth, y - padHeight] = newcolor;
                    this.bitmap.SetPixel(x - padWidth, y - padHeight, newcolor);

                }
            }

            return this;
        }
        public ImageP meanFilter(int filterwidth, int filterheight, int origx, int origy)
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
        public ImageP gaussianFilter1(float sigma,int size)
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
        public ImageP gaussianFilter2(float sigma)
        {
            int N = (int)((3.7*sigma)-.5);
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
                    double filtervalue1 = (x * x + y * y) / (2 * sigma * sigma);
                    filtervalue = filtervalue * filtervalue1;
                    filter[i , j ] = (float)Math.Exp(-(filtervalue));
                }
                y = -(size / 2);
            }

            return LinearFilter(filter, origx, origy, Postprocessing.No);

        }


    }
}
