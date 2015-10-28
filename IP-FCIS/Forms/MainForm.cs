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

namespace IP_FCIS.Forms
{
    public partial class MainForm : Form
    {
        public interface ImageBox
        {
            void save();
            void transformation();
            void gray_scale();
            void histogram();
            void brightness_contrast();
            void gamma_correction();
            void not();
            void bitplane();
            void quantization();
            void smooth();
        }
        public HistogramForm histogram_form;
        public List<ImageP> images_array;
        public MainForm()
        {
            InitializeComponent();
        } 
        private void OpenFile(object sender, EventArgs e)
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


                    this.open_this_mdi_picture(new_picture);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void open_this_mdi_picture(PictureForm pic_form)
        {
            pic_form.Width = pic_form.opened_image.get_width() + 50;
            pic_form.Height = pic_form.opened_image.get_height() + 50;
            pic_form.Text = pic_form.opened_image.get_file_name();
            images_array.Add(pic_form.opened_image);
            pic_form.MdiParent = this;
            pic_form.Show();
        }
        private void SaveFileAs(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //AllocConsole();
            try
            {
                this.toolStripInterpolation.Text = "Bilinear";
                this.images_array = new List<ImageP>();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        private void githubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/AlexanderHosnie/IP-FCIS");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Transformation(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).transformation();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void FileClose(object sender, EventArgs e)
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
            statusLabel_Width.Text = "Width: " + _width;
            statusLabel_Height.Text = "Height: " + _height;
        }
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).gray_scale();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null && this.ActiveMdiChild is ImageBox)
                {
                    ((PictureForm)this.ActiveMdiChild).histogram();

                } else
                {
                    if (this.histogram_form == null)
                    {
                        this.histogram_form = new HistogramForm();
                        this.histogram_form.MdiParent = this;
                        this.histogram_form.Text = "Histogram";
                        this.histogram_form.Show();

                    }

                }

                if (this.histogram_form != null)
                {
                    this.histogram_form.Activate();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).brightness_contrast();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).gamma_correction();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).not();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void imageAlgebraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                if(this.MdiChildren.Length > 1)
                {
                    AlgebraForm algebra_form = new AlgebraForm();
                    algebra_form.images_array = this.images_array;
                    algebra_form.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("At least 2 photos must be opened to make this action.");
                }
                

            //} catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void bitPlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ImageBox)this.ActiveMdiChild).bitplane();
        }

        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ImageBox)this.ActiveMdiChild).quantization();
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((PictureForm)this.ActiveMdiChild).smooth();
        }



    }
}
