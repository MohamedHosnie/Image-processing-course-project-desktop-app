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
using IP_FCIS.Forms;

//using System.Runtime.InteropServices;

namespace IP_FCIS.Forms
{
    public partial class MainForm : Form
    {
        public static ImageP opened_image;
        public interface ICommon
        {
            void set_new_image();
        }
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
                    PictureForm new_picture = new PictureForm();
                    string ext = Path.GetExtension(open.FileName);
                    if (ext.ToLower() == ".ppm")
                    {
                        new_picture.opened_image = new PPMImage(open.FileName);

                    } else
                    {
                        new_picture.opened_image = new CommonImage(open.FileName);
                    }

                    new_picture.Width = new_picture.opened_image.get_width() + 50;
                    new_picture.Height = new_picture.opened_image.get_height() + 50;
                    new_picture.Text = new_picture.opened_image.get_file_name();
                    new_picture.MdiParent = this;
                    new_picture.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opened_image != null)
            {
                SaveForm saveform = new SaveForm();
                saveform.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("No image to save.");
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
            Form active_child = this.ActiveMdiChild;
            if (active_child != null)
            {
                TransformationsForm trans_form = new TransformationsForm();
                trans_form.ShowDialog(this);

                ((ICommon)this.ActiveMdiChild).set_new_image();

            }
            
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form active_child = this.ActiveMdiChild;
                active_child.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void set_form_width_height_values(int _width, int _height)
        {
            toolStripStatusLabel1.Text = "Width: " + _width;
            toolStripStatusLabel2.Text = "Height: " + _height;
        }

    }
}
