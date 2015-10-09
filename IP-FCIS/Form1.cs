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
using System.IO;

//using System.Runtime.InteropServices;

namespace IP_FCIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ImageP opened_image;

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.ppm, *.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.ppm; *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(open.FileName);
                    if(ext == ".ppm")
                    {
                        opened_image = new PPMImage(open.FileName);

                    } else
                    {
                        opened_image = new CommonImage(open.FileName);
                    }

                    pictureBox1.Image = opened_image.get_bitmap();
                    toolStripStatusLabel1.Text = "Width: " + opened_image.get_width();
                    toolStripStatusLabel2.Text = "Height: " + opened_image.get_height();
                }

            //} catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm saveform = new SaveForm();
            saveform.Show();
            
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

        private void githubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AlexanderHosnie/IP-FCIS");
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

     



    }
}
