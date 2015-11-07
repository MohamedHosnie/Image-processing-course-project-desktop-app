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
            void sharp();
            void horizontal_edge();
            void vertical_edge();
            void magnitude_edge();
            void custom_filter();
            void Copy();

        }
        public HistogramForm histogram_form;
        public List<TypicalImage> images_array;
        public MainForm()
        {
            InitializeComponent();
        } 
        private void openPicFile(string _fileName)
        {
            PictureForm new_picture = new PictureForm();
            string ext = Path.GetExtension(_fileName);
            if (ext.ToLower() == ".ppm")
            {
                new_picture.opened_image = new TypicalImage(TypicalImage.Type.PPM, _fileName);

            }
            else
            {
                new_picture.opened_image = new TypicalImage(TypicalImage.Type.Common, _fileName);
            }


            this.open_this_mdi_picture(new_picture);
        }
        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.ppm, *.bmp, *.jpg, *.jpeg, *.png, *.gif, *.tif, *.tiff) | *.ppm; *.bmp; *.jpg; *.jpeg; *.png; *.gif; *.tif; *.tiff";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    openPicFile(open.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void open_this_mdi_picture(PictureForm pic_form)
        {
            //if(pic_form.opened_image.get_width() > (int)(Program.mainForm.Width / 1.5))
            //    pic_form.Width = (int)(Program.mainForm.Width / 1.5);
            //else
            //    pic_form.Width = pic_form.opened_image.get_width() + 30;

            //if (pic_form.opened_image.get_height() > (int)(Program.mainForm.Height - 200))
            //    pic_form.Height = (int)(Program.mainForm.Height - 200);
            //else
            //    pic_form.Height = pic_form.opened_image.get_height() + 50;

            pic_form.set_new_image();
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
                this.images_array = new List<TypicalImage>();

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
            try
            {
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
                

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bitPlaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).bitplane();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            try
            {
                ((ImageBox)this.ActiveMdiChild).quantization();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).smooth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).sharp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild is ImageBox)
                {
                    toolsToolStripMenuItem.Enabled = true;
                    copyToolStripMenuItem.Enabled = true;
                    copyToolStripButton.Enabled = true;

                }
                else
                {
                    toolsToolStripMenuItem.Enabled = false;
                    copyToolStripMenuItem.Enabled = false;
                    copyToolStripButton.Enabled = false;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    openPicFile(file);
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).horizontal_edge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).vertical_edge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void magnitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).magnitude_edge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PictureForm new_picture = new PictureForm();
                if(!Clipboard.ContainsData(DataFormats.Text))
                {
                    new_picture.opened_image = new TypicalImage((Bitmap)Clipboard.GetImage());
                }
                else
                {
                    IDataObject clips = Clipboard.GetDataObject();
                    new_picture.opened_image = new TypicalImage((Bitmap)clips.GetData(DataFormats.Bitmap), (string)clips.GetData(DataFormats.Text), true);
                }   
                this.open_this_mdi_picture(new_picture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).custom_filter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ImageBox)this.ActiveMdiChild).Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
