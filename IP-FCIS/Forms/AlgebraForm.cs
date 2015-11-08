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
    public partial class AlgebraForm : Form
    {
        public List<TypicalImage> images_array;
        public TypicalImage first, second, result;
        public AlgebraForm()
        {
            InitializeComponent();
        }
        private void AlgebraForm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < images_array.Count; i++)
                {
                    this.dropListImage1.Items.Add(images_array[i].get_file_name());
                    this.dropListImage2.Items.Add(images_array[i].get_file_name());
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dropListImage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                first = new TypicalImage(images_array[dropListImage1.SelectedIndex]);
                FirstImage.Image = first.get_bitmap();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        private void dropListImage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                second = new TypicalImage(images_array[dropListImage2.SelectedIndex]);
                SecondImage.Image = second.get_bitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dropListOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropListOperation.Text == "Add")
                {
                    panelFraction.Visible = true;

                } else
                {
                    panelFraction.Visible = false;
                    second.resize((float)first.get_width(), (float)first.get_height());
                    result = first.Subtract(second);
                    pictureBoxResult.Image = result.get_bitmap();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void trackFraction_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal value = (decimal)this.trackFraction.Value;
                this.numericFraction.Value = value / (decimal)100;
                second.resize((float)first.get_width(), (float)first.get_height());
                result = first.Add(second, (float)Convert.ToDouble(this.numericFraction.Value));
                pictureBoxResult.Image = result.get_bitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void numericFraction_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.trackFraction.Value = Convert.ToInt32(this.numericFraction.Value * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                PictureForm new_picture = new PictureForm();
                result.id = TypicalImage.get_an_id();
                result.set_file_name("Image" +  result.id + "." + first.get_extension());
                new_picture.opened_image = result;
                Program.mainForm.open_this_mdi_picture(new_picture);
                new_picture.Activate();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       



    }
}
