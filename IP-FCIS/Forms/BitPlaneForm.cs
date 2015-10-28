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
        public ImageP image;
        List<int> mask;
        List<char> colors;
        private Boolean clicked;
        public BitPlaneForm()
        {
            InitializeComponent();
            pictureBox_array = new List<PictureBox>();
            mask = new List<int>();
            colors = new List<char>();
        }

        private void BitPlaneForm_Load(object sender, EventArgs e)
        {
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
            for (int i = 1; i < pictureBox_array.Count + 1; i++)
            {
              

                if (i <= 8)
                {
                    if (sender.Equals(pictureBox_array[i - 1]))
                    {
                        if (pictureBox_array[i - 1].BorderStyle == BorderStyle.None)
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.None;
                        }

                        int maskID = int.Parse(pictureBox_array[i - 1].Name[pictureBox_array[i - 1].Name.Length - 1].ToString());
                        maskID--;
                        modifiedBox.Image = image.bitPlane_remove('R', mask[maskID]).get_bitmap();
                    }

                }


                else if (i > 8 && i <= 16)
                {
                    if (sender.Equals(pictureBox_array[i - 1]))
                    {
                        if (pictureBox_array[i - 1].BorderStyle == BorderStyle.None)
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.Fixed3D;
                        }
                        else
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.None;
                        }
                        int maskID = int.Parse(pictureBox_array[i - 1].Name[pictureBox_array[i - 1].Name.Length - 1].ToString());
                        if (i >= 10)
                        {
                            maskID += 10;
                        }
                        maskID = maskID - 9;
                        modifiedBox.Image = image.bitPlane_remove('G', mask[maskID]).get_bitmap();
                    }
                }
                else if (i > 16 && i <= 24)
                {
                    if (sender.Equals(pictureBox_array[i - 1]))
                    {
                        if (pictureBox_array[i - 1].BorderStyle == BorderStyle.None)
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.Fixed3D;
                        }
                        else 
                        {
                            pictureBox_array[i - 1].BorderStyle = BorderStyle.None;
                        }
                        int maskID = int.Parse(pictureBox_array[i - 1].Name[pictureBox_array[i - 1].Name.Length - 1].ToString());
                        if (i > 10 && i < 20)
                        {
                            maskID = maskID - 7;
                        }

                        else if (i >= 20)
                        {
                            maskID = maskID + 3;
                        }
                        modifiedBox.Image = image.bitPlane_remove('B', mask[maskID]).get_bitmap();
                    }
                }

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
    }
}
