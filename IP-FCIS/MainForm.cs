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
using System.Runtime.InteropServices;

//using System.Runtime.InteropServices;

namespace IP_FCIS
{
    public partial class MainForm : Form
    {
        public static ImageP opened_image;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.ppm, *.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.ppm; *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(open.FileName);
                    if (ext.ToLower() == ".ppm")
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(opened_image != null)
            {
                SaveForm saveform = new SaveForm();
                saveform.ShowDialog(this);

            } else
            {
                MessageBox.Show("No image to save.");
            }
            
        }
        private void toolStripZoom_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void toolStripOriginal_Click(object sender, EventArgs e)
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
        private void githubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AlexanderHosnie/IP-FCIS");
        }
        private void geometricTransformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(opened_image != null)
            {
                TransformationsForm trans_form = new TransformationsForm();
                trans_form.ShowDialog(this);

                pictureBox1.Image = opened_image.get_bitmap();
                toolStripStatusLabel1.Text = "Width: " + opened_image.get_width();
                toolStripStatusLabel2.Text = "Height: " + opened_image.get_height();

            } else
            {
                MessageBox.Show("No Image is opened to Transform.");
            }
            
            
        }
       

    }
}
