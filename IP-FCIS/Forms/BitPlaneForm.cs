using IP_FCIS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_FCIS.Forms
{
    public partial class BitPlaneForm : Form
    {
        List<PictureBox> pictureBox_array;
        public TypicalImage source, image, result;
        List<int> mask;
        List<char> colors;
        int R, G, B;
        public BitPlaneForm()
        {
            InitializeComponent();
            pictureBox_array = new List<PictureBox>();
            mask = new List<int>();
            colors = new List<char>();
            R = 255; G = 255; B = 255;
        }
        private void BitPlaneForm_Load(object sender, EventArgs e)
        {
            try
            {

                int width, height;
                image = new TypicalImage(source);
                if (image.get_width() > 250 || image.get_height() > 250)
                {
                    if (image.get_width() > image.get_height())
                    {
                        width = 250;
                        height = (width * image.get_height()) / image.get_width();

                    }
                    else
                    {
                        height = 250;
                        width = (height * image.get_width()) / image.get_height();
                    }

                    image.resize(width, height);
                }
                this.Original.Image = this.image.get_bitmap();
                this.Result.Image = this.image.get_bitmap();

                loadData();
                int counter = 0;
                for (int i = 0; i < colors.Count; i++)
                {
                    for (int j = 0; j < mask.Count; j++)
                    {
                        pictureBox_array[counter].Image = image.bitplane(colors[i], mask[j]).get_bitmap();
                        counter++;
                    }

                }

                actions();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void actions()
        {

            for (int i = 0; i < pictureBox_array.Count; i++)
            {

                pictureBox_array[i].Click += new System.EventHandler(this.picbox_click);
            }

        }
        private void picbox_click(object sender, EventArgs e)
        {
            try
            {
                R = 0; G = 0; B = 0;
                for (int i = 0; i < pictureBox_array.Count; i++)
                {

                    if (sender.Equals(pictureBox_array[i]))
                    {
                        if (pictureBox_array[i].BorderStyle == BorderStyle.Fixed3D)
                            pictureBox_array[i].BorderStyle = BorderStyle.None;
                        else
                            pictureBox_array[i].BorderStyle = BorderStyle.Fixed3D;
                    }


                    if (pictureBox_array[i].BorderStyle == BorderStyle.Fixed3D)
                    {
                        if (i < 8)
                        {
                            R += mask[i];
                        }
                        else if (i >= 8 && i < 16)
                        {
                            G += mask[i - 8];
                        }
                        else if (i >= 16 && i < 24)
                        {
                            B += mask[i - 16];
                        }
                    }

                }

                result = image.bitplane_slicing(Color.FromArgb(R, G, B));
                Result.Image = result.get_bitmap();
                Red.Text = "Red: " + Convert.ToString(R, 2);
                Green.Text = "Green: " + Convert.ToString(G, 2);
                Blue.Text = "Blue: " + Convert.ToString(B, 2);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loadData()
        {
            pictureBox_array.Add(pictureBox1);
            pictureBox_array.Add(pictureBox2);
            pictureBox_array.Add(pictureBox3);
            pictureBox_array.Add(pictureBox4);
            pictureBox_array.Add(pictureBox5);
            pictureBox_array.Add(pictureBox6);
            pictureBox_array.Add(pictureBox7);
            pictureBox_array.Add(pictureBox8);
            pictureBox_array.Add(pictureBox9);
            pictureBox_array.Add(pictureBox10);
            pictureBox_array.Add(pictureBox11);
            pictureBox_array.Add(pictureBox12);
            pictureBox_array.Add(pictureBox13);
            pictureBox_array.Add(pictureBox14);
            pictureBox_array.Add(pictureBox15);
            pictureBox_array.Add(pictureBox16);
            pictureBox_array.Add(pictureBox17);
            pictureBox_array.Add(pictureBox18);
            pictureBox_array.Add(pictureBox19);
            pictureBox_array.Add(pictureBox20);
            pictureBox_array.Add(pictureBox21);
            pictureBox_array.Add(pictureBox22);
            pictureBox_array.Add(pictureBox23);
            pictureBox_array.Add(pictureBox24);

            mask.Add(1);
            mask.Add(2);
            mask.Add(4);
            mask.Add(8);
            mask.Add(16);
            mask.Add(32);
            mask.Add(64);
            mask.Add(128);

            colors.Add('R');
            colors.Add('G');
            colors.Add('B');
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                source = source.bitplane_slicing(Color.FromArgb(R, G, B));
                this.Hide();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



    }
}
