using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_FCIS.Classes;

//using System.Runtime.InteropServices;

namespace IP_FCIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ImageP opened_image;

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    CommonImage img = new CommonImage(open.FileName);
                    opened_image = img;
                    pictureBox1.Width = img.get_width();
                    pictureBox1.Height = img.get_height();
                    pictureBox1.Image = img.get_bitmap();


                    toolStripStatusLabel1.Text = "Width: " + img.get_width();
                    toolStripStatusLabel2.Text = "Height: " + img.get_height();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pPMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.ppm) | *.ppm";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    PPMImage img = new PPMImage(open.FileName);
                    opened_image = img;
                    pictureBox1.Width = img.get_width();
                    pictureBox1.Height = img.get_height();
                    pictureBox1.Image = img.get_bitmap();

                    toolStripStatusLabel1.Text = "Width: " + img.get_width();
                    toolStripStatusLabel2.Text = "Height: " + img.get_height();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

     



    }
}
